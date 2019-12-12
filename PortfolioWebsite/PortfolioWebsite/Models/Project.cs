using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioWebsite.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectTitle { get; set; }
        public string Description { get; set; }
        public string[] Pictures { get; set; }
    }
}