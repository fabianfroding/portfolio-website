using PortfolioWebsite.Models;
using System.Collections.Generic;

namespace PortfolioWebsite.Service
{
    public interface IProjectService
    {
        Project GetById(int id);
        List<Project> GetAll();
        void Add(Project project);
        void Remove(Project project);
    }
}