﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Disco.Data.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using Disco.Data.Repository;
using Disco.Models.BI.Interop.Community;
using Disco.Services.Tasks;
using Disco.Models.Interop.ActiveDirectory;
using System.DirectoryServices.ActiveDirectory;
using Disco.Services.Interop.ActiveDirectory;

namespace Disco.Web.Areas.Config.Models.SystemConfig
{
    public class IndexModel
    {
        public Version DiscoVersion { get; set; }
        public DateTime? DiscoVersionBuilt
        {
            get
            {
                var v = DiscoVersion;
                if (v != null)
                {
                    try
                    {
                        return new DateTime(v.Minor + 2011, v.Build / 100, v.Build % 100, v.Revision / 100, v.Revision % 100, 0);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
                else
                    return null;
            }
        }

        public string DataStoreLocation { get; set; }

        #region Database Connection
        private Lazy<SqlConnectionStringBuilder> DatabaseConnectionString = new Lazy<SqlConnectionStringBuilder>(() =>
        {
            return new SqlConnectionStringBuilder(Disco.Data.Repository.DiscoDatabaseConnectionFactory.DiscoDataContextConnectionString);
        });
        public string DatabaseServer
        {
            get
            {
                return this.DatabaseConnectionString.Value.DataSource;
            }
        }
        public string DatabaseName
        {
            get
            {
                return this.DatabaseConnectionString.Value.InitialCatalog;
            }
        }
        public string DatabaseAuthentication
        {
            get
            {
                return this.DatabaseConnectionString.Value.IntegratedSecurity ? "Integrated Authentication" : "SQL Authentication";
            }
        }
        public string DatabaseSqlAuthUsername
        {
            get
            {
                return this.DatabaseConnectionString.Value.IntegratedSecurity ? null : this.DatabaseConnectionString.Value.UserID;
            }
        }
        #endregion

        #region Active Directory

        [Display(Name="Search Entire Forest")]
        public bool ADSearchEntireForest { get; set; }

        public ActiveDirectoryDomain ADPrimaryDomain { get; set; }
        public List<ActiveDirectoryDomain> ADAdditionalDomains { get; set; }
        public ActiveDirectorySite ADSite { get; set; }
        public List<Tuple<DirectoryServer, bool>> ADSiteServers { get; set; }
        public List<Tuple<string, ActiveDirectoryDomain, string>> ADSearchContainers { get; set; }
        public List<string> ADForestServers { get; set; }

        #endregion

        #region Proxy
        public string ProxyAddress { get; set; }
        public int ProxyPort { get; set; }
        public string ProxyUsername { get; set; }
        [DataType(DataType.Password)]
        public string ProxyPassword { get; set; }
        #endregion

        public ScheduledTaskStatus UpdateRunningStatus { get; set; }
        public DateTime? UpdateNextScheduled { get; set; }
        public UpdateResponse UpdateLatestResponse { get; set; }
        public bool UpdateBetaDeployment { get; set; }

        public static IndexModel FromConfiguration(SystemConfiguration config)
        {
            var m = new IndexModel()
            {
                DiscoVersion = typeof(DiscoApplication).Assembly.GetName().Version,
                DataStoreLocation = config.DataStoreLocation,
                ProxyAddress = config.ProxyAddress,
                ProxyPort = config.ProxyPort,
                ProxyUsername = config.ProxyUsername,
                ProxyPassword = config.ProxyPassword,
                UpdateLatestResponse = config.UpdateLastCheck,
                UpdateRunningStatus = Disco.BI.Interop.Community.UpdateCheckTask.RunningStatus,
                UpdateNextScheduled = Disco.BI.Interop.Community.UpdateCheckTask.NextScheduled,
                UpdateBetaDeployment = config.UpdateBetaDeployment
            };

            // AD
            m.ADPrimaryDomain = ActiveDirectory.PrimaryDomain;
            m.ADAdditionalDomains = ActiveDirectory.Domains.Where(d => d != m.ADPrimaryDomain).ToList();
            m.ADSite = ActiveDirectory.Site;
            m.ADSiteServers = m.ADSite.Servers.Cast<DirectoryServer>().Select(s => Tuple.Create(s, s.Reachable())).ToList();
            var configSearchContainers = config.ActiveDirectory.SearchContainers;
            m.ADSearchContainers = configSearchContainers == null ? null : configSearchContainers.SelectMany(d => d.Value, (k, c) =>
            {
                var domain = ActiveDirectory.GetDomainByDnsName(k.Key);
                return Tuple.Create(c, domain, domain.GetFriendlyOrganisationalUnitName(c));
            }).ToList();

            var loadForestServersTask = ActiveDirectory.LoadForestServersAsync();
            if (loadForestServersTask.Wait(TimeSpan.FromSeconds(1)))
            {
                m.ADForestServers = loadForestServersTask.Result;
                var configValue = config.ActiveDirectory.SearchEntireForest ?? true;
                m.ADSearchEntireForest = configValue && m.ADForestServers.Count <= ActiveDirectory.MaxForestServerSearch;
            }
            else
            {
                m.ADForestServers = null;
                m.ADSearchEntireForest = config.ActiveDirectory.SearchEntireForest ?? true;
            }

            return m;
        }
    }
}