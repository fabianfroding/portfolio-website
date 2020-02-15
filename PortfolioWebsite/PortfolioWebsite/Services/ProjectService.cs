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

        public List<Project> GetAllByTitle(string searchText)
        {
            return _projectRepository.GetAllByTitle(searchText);
        }

        public void Add(Project project, string serverMapPath)
        {
            SetProjectImageFiles(project, serverMapPath);
            _projectRepository.Add(project);
        }

        public void Remove(Project project)
        {
            _projectRepository.Remove(project);
        }

        public void Save(Project project, string serverMapPath)
        {
            // Get old images.
            List<String> existingImages = _projectRepository.GetById(project.Id).Images;
            project.Images.AddRange(existingImages);
            // TODO: Fix obj ref not set ot inst of obj...
            if (project.ImageFiles.Count > 0)
            {
               SetProjectImageFiles(project, serverMapPath);
            }
            _projectRepository.Save(project);
        }

        private void SetProjectImageFiles(Project project, string serverMapPath)
        {
            for (int i = 0; i < project.ImageFiles.Count; i++)
            {
                string fileName =
                    Path.GetFileNameWithoutExtension(project.ImageFiles[i].FileName) +
                    DateTime.Now.ToString("yymmssfff") +
                    Path.GetExtension(project.ImageFiles[i].FileName);
                // Remove commas from the filename to prevent problems with
                // comma-separation which is used in the Project class.
                fileName = fileName.Replace(",", "");
                project.Images.Add("~/Images/" + fileName);
                fileName = Path.Combine(serverMapPath, fileName);
                project.ImageFiles[i].SaveAs(fileName);
            }
        }
    }
}