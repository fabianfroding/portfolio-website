using PortfolioWebsite.Models;
using System.Collections.Generic;

namespace PortfolioWebsite.Repositories
{
    public interface IProjectRepository
    {
        Project GetById(int id);
        List<Project> GetAll();
        void Add(Project project);
        void Remove(Project project);
        void Save(Project project);
    }
}