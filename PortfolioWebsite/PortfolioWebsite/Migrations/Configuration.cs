namespace PortfolioWebsite.Migrations
{
    using PortfolioWebsite.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PortfolioWebsite.Data.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PortfolioWebsite.Data.ProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var projects = new Project[]
            {
                new Project()
                {
                    Id = 1,
                    Title = "Vault of Darkness",
                    Description = "A mod for Warcraft III",
                    Images = new List<string>()
                    {
                        "~/Images/temp/vod-1.png",
                        "~/Images/temp/vod-2.png",
                        "~/Images/temp/vod-3.jpg",
                        "~/Images/temp/vod-4.png"
                    }
                },

                new Project()
                {
                    Id = 2,
                    Title = "My siberia notebook",
                    Description = "An app to register events in siberia",
                    Images = new List<string>()
                    {
                        "~/Images/temp/husky-1.jpg",
                        "~/Images/temp/husky-2.jpg",
                        "~/Images/temp/husky-3.jpg"
                    }
                },

                new Project()
                {
                    Id = 3,
                    Title = "Wish",
                    Description = "A game in unity",
                    Images = new List<string>()
                    {
                        "~/Images/temp/wish-1.jpg",
                        "~/Images/temp/wish-2.jpg"
                    }
                }
            };

            for (var i = 0; i < projects.Length; i++)
            {
                context.Projects.Add(projects[i]);
            }
            context.SaveChanges();
        }
    }
}
