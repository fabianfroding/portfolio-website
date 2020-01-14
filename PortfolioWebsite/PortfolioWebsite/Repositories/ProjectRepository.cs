using System;
using System.Collections.Generic;
using System.Linq;
using PortfolioWebsite.Data;
using PortfolioWebsite.Models;

namespace PortfolioWebsite.Repositories
{
    public class ProjectRepository : IProjectRepository, IDisposable
    {
        // Move this stuff to db initializer when it is implemented.
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

        private ProjectContext _projectContext;

        public ProjectRepository()
        {
            _projectContext = new ProjectContext();
        }

        public Project GetById(int id)
        {
            foreach (var project in _projects)
            {
                if (project.Id == id)
                {
                    return project;
                }
            }
            return null;
            //return _projectContext.Projects.SingleOrDefault(c => c.Id == id);
        }

        public List<Project> GetAll()
        {
            return _projects.ToList();
            //return _projectContext.Projects.ToArray<Project>();
        }

        public void Add(Project project)
        {
            _projectContext.Projects.Add(project);
            _projectContext.SaveChanges();
        }

        public void Remove(Project project)
        {
            _projectContext.Projects.Remove(project);
            _projectContext.SaveChanges();
        }

        public void Dispose()
        {
            _projectContext.Dispose();
        }
    }
}