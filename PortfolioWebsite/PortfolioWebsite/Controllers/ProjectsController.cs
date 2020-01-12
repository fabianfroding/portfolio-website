using PortfolioWebsite.Models;
using System;
using System.Web.Mvc;
using System.IO;
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
            ViewBag.Message = "Add";
            return View();
        }

        [HttpPost]
        public ActionResult Add(Project project)
        {
            // Move this stuff to somewhere more appropriate.
            string fileName = Path.GetFileNameWithoutExtension(project.ImageFile.FileName);
            string extension = Path.GetExtension(project.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            project.ImagePath = "~/Images/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
            project.ImageFile.SaveAs(fileName);

            _projectService.Add(project);

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            ModelState.Clear();
            return View();
        }
    }
}