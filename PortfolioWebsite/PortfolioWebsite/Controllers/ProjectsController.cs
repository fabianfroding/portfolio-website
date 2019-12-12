using PortfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        public ActionResult Detail()
        {
            var project = new Project()
            {
                ProjectTitle = "Vault of Darkness",
                Description = "A mod for Warcraft III",
                Images = new String[]
                {
                    "~/Images/screenshots-vod/1.png",
                    "~/Images/screenshots-vod/2.png",
                    "~/Images/screenshots-vod/3.jpg"
                }
            };
            return View(project);
        }
    }
}