using System;
using System.Collections.Generic;
using System.Linq;
using PortfolioWebsite.Data;
using PortfolioWebsite.Models;

namespace PortfolioWebsite.Repository
{
    public class ProjectRepository : IProjectRepository, IDisposable
    {
        private ProjectContext _projectContext;
        private ProjectRepositoryLocal _projectRepositoryLocal; // Temp, remove when replaced with context

        public ProjectRepository()
        {
            _projectContext = new ProjectContext();
            _projectRepositoryLocal = new ProjectRepositoryLocal();
        }

        public Project GetById(int id)
        {
            return _projectRepositoryLocal.GetProject(id);
            //var project = _projectContext.Projects.SingleOrDefault(c => c.Id == id);
        }

        public List<Project> GetAll()
        {
            return _projectRepositoryLocal.GetProjects().ToList();
            //var projects = _projectContext.Projects.ToArray<Project>();
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