using PortfolioWebsite.Data;
using PortfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.Entity.Validation;

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
        public ActionResult Add(Project project, HttpPostedFileBase file)
        {
            string fileName = Path.GetFileNameWithoutExtension(project.CoverImageFile.FileName);
            string extension = Path.GetExtension(project.CoverImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            project.Images[0] = "~/Images/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
            //System.Diagnostics.Debug.WriteLine("Filename(Combined): " + fileName);
            project.CoverImageFile.SaveAs(fileName);

            // DB stuff. Move to data access class? Separation of concerns...
            using (ProjectContext db = new ProjectContext())
            {
                db.Projects.Add(project);
                db.SaveChanges();
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            ModelState.Clear();
            return View();
        }
    }
}