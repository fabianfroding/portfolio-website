using PortfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioWebsite.BusinessLogic
{
    public static class ProjectProcessor
    {
        public static string ImagesToString(Project project)
        {
            if (project.Images.Length == 0)
            {
                return null;
            }
            string s = "";
            for (int i = 0; i < project.Images.Length; i++)
            {
                if (i < project.Images.Length - 1)
                {
                    s += project.Images[i] + ",";
                }
                else
                {
                    s += project.Images[i];
                }
            }
            return s;
        }
    }
}