using PortfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioWebsite.Data
{
    public class ProjectRepository
    {
        private static Project[] _projects = new Project[]
        {
            new Project()
            {
                Id = 1,
                Title = "Vault of Darkness",
                Description = "A mod for Warcraft III",
                Images = new String[]
                {
                    "~/Images/screenshots-vod/1.png",
                    "~/Images/screenshots-vod/2.png",
                    "~/Images/screenshots-vod/3.jpg"
                }
            },
            new Project()
            {
                Id = 2,
                Title = "My siberia notebook",
                Description = "An app to register events in siberia",
                Images = new String[]
                {
                    "~/Images/screenshots-vod/1.png",
                    "~/Images/screenshots-vod/2.png",
                    "~/Images/screenshots-vod/3.jpg"
                }
            },
            new Project()
            {
                Id = 3,
                Title = "Wish",
                Description = "A game in unity",
                Images = new String[]
                {
                    "~/Images/screenshots-vod/1.png",
                    "~/Images/screenshots-vod/2.png",
                    "~/Images/screenshots-vod/3.jpg"
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