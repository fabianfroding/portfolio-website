using PortfolioWebsite.Models;
using System.Collections.Generic;

namespace PortfolioWebsite.Repositories
{
    // Move this stuff to db initializer when implemented.
    public class ProjectRepositoryLocal
    {
        private static Project[] _projects = new Project[]
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

        public Project[] GetProjects()
        {
            return _projects;
        }

        public Project GetProject(int id)
        {
            foreach (var project in _projects)
            {
                if (project.Id == id)
                {
                    return project;
                }
            }
            return null;
        }
    }
}