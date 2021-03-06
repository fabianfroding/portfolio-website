﻿using PortfolioWebsite.Models;
using System.Web.Mvc;
using PortfolioWebsite.Services;
using System.Net;

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

        public ActionResult Slideshow()
        {
            return View(_projectService.GetAll().ToArray());
        }

        [HttpGet]
        public ActionResult Search(string searchText)
        {
            return View(_projectService.GetAllByTitle(searchText).ToArray());
        }

        [HttpGet]
        public ActionResult Grid()
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
            Project project = new Project(); // Temp to avoid null exception in view.
            return View(project);
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
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            System.Diagnostics.Debug.WriteLine("HttpGet Edit called in controller");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Project project = _projectService.GetById(id.Value);

            if (project == null)
            {
                return HttpNotFound();
            }

            return View(project);
        }

        [HttpPost]
        public ActionResult Edit(Project project)
        {
            if (Request.Form["save-project"] != null)
            {
                if (ModelState.IsValid)
                {
                    _projectService.Save(project, Server.MapPath("~/Images/"));
                    return RedirectToAction("Index");
                }
            }
            else if (Request.Form["delete-project-image"] != null)
            {
                System.Diagnostics.Debug.WriteLine("Delete image button clicked");
            }
            return View(project); // After click dlete img btn, doesnt list any images after refreshing view.
        }

        public ActionResult Remove(Project project)
        {
            _projectService.Remove(project);
            return RedirectToAction("Index");
        }
    }
}