using Two_Datacontext_One_wEB.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Two_Datacontext_One_wEB.DataContexts
{
    public class Identity : IdentityDbContext<ApplicationUser>
    {
        public Identity()
            : base("DefaultConnection")
        {
        }
    }
}