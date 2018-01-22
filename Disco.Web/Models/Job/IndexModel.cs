﻿using Disco.Models.Services.Job.Statistics;
using Disco.Models.Services.Jobs.JobLists;
using Disco.Models.UI.Job;
using System.Collections.Generic;

namespace Disco.Web.Models.Job
{
    public class IndexModel : JobIndexModel
    {
        public JobTableModel MyJobs { get; set; }
        public JobTableModel StaleJobs { get; set; }

        public List<DailyOpenedClosedItem> DailyOpenedClosedStatistics { get; set; }
    }
}