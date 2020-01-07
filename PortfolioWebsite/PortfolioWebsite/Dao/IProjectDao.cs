using PortfolioWebsite.Models;
using System.Collections.Generic;

namespace PortfolioWebsite.Dao
{
    public interface IProjectDao
    {
        List<Project> findAll();
        Project findById(int id);
        void save(Project project);
        void delete(Project project);
    }
}