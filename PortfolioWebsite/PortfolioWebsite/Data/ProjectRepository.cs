using PortfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioWebsite.Data
{
    public class ProjectRepository
    {
        private static Project[] _Projects = new Project[]
        {
            new Project()
            {
                ProjectTitle = "Vault of Darkness",
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
                ProjectTitle = "Celestial Walkway",
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
                ProjectTitle = "RPG",
                Description = "A mod for Warcraft III",
                Images = new String[]
                {
                    "~/Images/screenshots-vod/1.png",
                    "~/Images/screenshots-vod/2.png",
                    "~/Images/screenshots-vod/3.jpg"
                }
            }
        };
        public Project GetProject(int Id)
        {
            foreach (var project in _Projects)
            {
                if (project.Id == Id)
                {
                    return project;
                }
            }
            return null;
        }
        public Project[] GetProjects()
        {
            return _Projects;
        }
    }
}