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
            return new ContentResult()
            {
                Content = "Oh hello!"
            };
        }
    }
}