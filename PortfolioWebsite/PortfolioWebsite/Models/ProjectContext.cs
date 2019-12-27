using PortfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PortfolioWebsite.Data
{
    public class ProjectContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
    }
}