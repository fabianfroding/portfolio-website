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
        private ProjectContext _projectContext;
        private ProjectRepository _projectRepository = null;
        public ProjectsController()
        {
            _projectRepository = new ProjectRepository();
            _projectContext = new ProjectContext();
        }
        protected override void Dispose(bool disposing)
        {
            _projectContext.Dispose();
        }
        public ActionResult Index()
        {
            var projects = _projectRepository.GetProjects();
            //var projects = _projectContext.Projects.ToArray<Project>();
            return View(projects);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var project = _projectRepository.GetProject(id.Value);
            //var project = _projectContext.Projects.SingleOrDefault(c => c.Id == id);
            return View(project);
        }
        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.Message = "Add";
            return View();
        }
        [HttpPost]
        public ActionResult Add(Project project)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}