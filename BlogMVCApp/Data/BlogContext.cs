using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BlogMVCApp.Models;

namespace BlogMVCApp.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext():base("myblogDbConnection")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Article> Articles { get; set; }

    }
}