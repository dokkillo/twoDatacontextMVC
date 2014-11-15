namespace EFBlog.DataContexts.IdentityMigrations
{
    using EFBlog.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using Two_Datacontext_One_wEB.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Two_Datacontext_One_wEB.DataContexts.Identity>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\IdentityMigrations";
        }

        protected override void Seed(Two_Datacontext_One_wEB.DataContexts.Identity context)
        {
            base.Seed(context);

          
             CreateRoles(context, "Admin");
           
                  
        
            if (!context.Users.Any(u => u.UserName == "Admim"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "Admin" };

                manager.Create(user, "AdminPwd");
                manager.AddToRole(user.Id, "Admin");
              
            }

        }

        private static void CreateRoles(Two_Datacontext_One_wEB.DataContexts.Identity context, string rolName)
        {
            if (!context.Roles.Any(r => r.Name == rolName))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = rolName };

                manager.Create(role);
            }
        }
    }
}
