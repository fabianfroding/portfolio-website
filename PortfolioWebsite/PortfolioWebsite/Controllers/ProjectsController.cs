using PortfolioWebsite.Models;
using System.Web.Mvc;
using PortfolioWebsite.Services;

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
        private ProjectService _projectService;

        public ProjectsController()
        {
            _projectService = new ProjectService();
        }

        public ActionResult Index()
        {
            return View(_projectService.GetAll().ToArray());
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            return View(_projectService.GetById(id.Value));
        }

        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.Message = "Form";
            return View("Form");
        }

        [HttpPost]
        public ActionResult Add(Project project)
        {
            _projectService.Add(project, Server.MapPath("~/Images/"));

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            ModelState.Clear();
            return View("Form");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Project project = _projectService.GetById(id.Value);

            //project.Title = "NewTitle";
            //project.Description = "New Descrption";
            // Allow adding and removal of images. How to update?

            return View("Form", project);
        }
    }
}