using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Two_Datacontext_One_wEB.Models;

namespace Two_Datacontext_One_wEB.DataContexts
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public BlogContext()
            : base("DefaultConnection")
        {
        }
    }
}