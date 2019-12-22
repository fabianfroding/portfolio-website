using PortfolioWebsite.Data;
using PortfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/* Action Result return types:
 * View(model);
 * Content("message");
 * HttpNotFound();
 * new EmptyResult();
 * RedirectToAction("Index", "Home", new {page = 1, , sortBy="name");
 * */

namespace PortfolioWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        private ProjectRepository _projectRepository = null;
        public ProjectsController()
        {
            _projectRepository = new ProjectRepository();
        }
        public ActionResult Index()
        {
            var projects = _projectRepository.GetProjects();
            return View(projects);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var project = _projectRepository.GetProject(id.Value);
            return View(project);
        }
        public ActionResult Add()
        {
            ViewBag.Message = "Add";
            return View();
        }
    }
}