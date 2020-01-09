using PortfolioWebsite.Models;
using System.Data.Entity;

namespace PortfolioWebsite.Data
{
    public class ProjectContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
    }
}