using System;
using System.Collections.Generic;
using System.Linq;
using PortfolioWebsite.Data;
using PortfolioWebsite.Models;

namespace PortfolioWebsite.Repositories
{
    public class ProjectRepository : IProjectRepository, IDisposable
    {
        private ProjectContext _projectContext;

        public ProjectRepository()
        {
            _projectContext = new ProjectContext();
        }

        public Project GetById(int id)
        {
            return _projectContext.Projects.SingleOrDefault(c => c.Id == id);
        }

        public List<Project> GetAll()
        {
            return _projectContext.Projects.ToList();
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