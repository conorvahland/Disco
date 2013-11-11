﻿using Disco.Models.Repository;
using Disco.Services.Authorization;
using Disco.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Disco.Services.Web
{
    [DiscoAuthorize]
    public abstract class AuthorizedController : BaseController
    {
        public AuthorizationToken Authorization
        {
            get
            {
                return UserService.CurrentAuthorization;
            }
        }

        public User CurrentUser
        {
            get
            {
                return UserService.CurrentUser;
            }
        }
    }
}
