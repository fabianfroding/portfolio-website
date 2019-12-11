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
            ViewBag.ProjectTitle = "Vault of Darkness";
            ViewBag.Description = "A mod for Warcraft III";
            ViewBag.Type = "Game Mod";
            ViewBag.Pictures = new String[]
            {
                "Pic1",
                "Pic2",
                "Pic3"
            };
            return View();
        }
    }
}