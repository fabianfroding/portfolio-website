using System;
using System.Collections.Generic;
using System.IO;
using PortfolioWebsite.Models;
using PortfolioWebsite.Repositories;

namespace PortfolioWebsite.Services
{
    public class ProjectService : IProjectService
    {
        private ProjectRepository _projectRepository;

        public ProjectService()
        {
            _projectRepository = new ProjectRepository();
        }

        public Project GetById(int id)
        {
            Project project = _projectRepository.GetById(id);
            project.ImagesAsString = project.ImagesAsString;
            return project;
        }

        public List<Project> GetAll()
        {
            List<Project> projects = _projectRepository.GetAll();
            foreach (var project in projects)
            {
                project.ImagesAsString = project.ImagesAsString;
            }
            return projects;
        }

        public void Add(Project project, string serverMapPath)
        {
            SetProjectImageFile(project, serverMapPath);
            _projectRepository.Add(project);
        }

        public void Remove(Project project)
        {
            _projectRepository.Remove(project);
        }

        public void Save(Project project, string serverMapPath)
        {
            SetProjectImageFile(project, serverMapPath);
            _projectRepository.Save(project);
        }

        private void SetProjectImageFile(Project project, string serverMapPath)
        {
            string fileName =
                Path.GetFileNameWithoutExtension(project.ImageFile.FileName) +
                DateTime.Now.ToString("yymmssfff") +
                Path.GetExtension(project.ImageFile.FileName);
            // Remove commas from the filename to prevent problems with
            // comma-separation which is used in the Project class.
            fileName = fileName.Replace(",", "");
            project.Images.Add("~/Images/" + fileName);
            fileName = Path.Combine(serverMapPath, fileName);
            project.ImageFile.SaveAs(fileName);
        }
    }
}