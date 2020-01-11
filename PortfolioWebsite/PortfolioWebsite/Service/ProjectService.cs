using System;
using System.Collections.Generic;
using PortfolioWebsite.Models;
using PortfolioWebsite.Repository;

namespace PortfolioWebsite.Service
{
    public class ProjectService : IProjectService
    {
        private ProjectRepository _projectRepository;

        public ProjectService()
        {
            _projectRepository = new ProjectRepository();
        }

        public Project GetById(int id)
        {
            return _projectRepository.GetById(id);
        }

        public List<Project> GetAll()
        {
            return _projectRepository.GetAll();
        }

        public void Add(Project project)
        {
            _projectRepository.Add(project);
        }

        public void Remove(Project project)
        {
            _projectRepository.Remove(project);
        }
    }
}