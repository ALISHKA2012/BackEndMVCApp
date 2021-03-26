namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogMVCApp.Data.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BlogMVCApp.Data.BlogContext context)
        {
            context.Menus.AddOrUpdate
            (
                new Models.Menu
                {
                    IsActive = true,
                    Name = "Travel",
                    ControllerName = "Home",
                    ActionName = "Travel",
                    Order = 1
                },
                     new Models.Menu
                     {
                         IsActive = true,
                         Name = "Fashion",
                         ControllerName = "Home",
                         ActionName = "Fashion",
                         Order = 2
                     },
                          new Models.Menu
                          {
                              IsActive = true,
                              Name = "About",
                              ControllerName = "Home",
                              ActionName = "About",
                              Order = 3
                          },
                               new Models.Menu
                               {
                                   IsActive = true,
                                   Name = "Contact",
                                   ControllerName = "Home",
                                   ActionName = "Contact",
                                   Order = 4
                               }
            );
        }
    }
}