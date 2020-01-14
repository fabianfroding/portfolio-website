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
            return _projectRepository.GetById(id);
        }

        public List<Project> GetAll()
        {
            return _projectRepository.GetAll();
        }

        public void Add(Project project, string serverMapPath)
        {
            string fileName = 
                Path.GetFileNameWithoutExtension(project.ImageFile.FileName) +
                DateTime.Now.ToString("yymmssfff") +
                Path.GetExtension(project.ImageFile.FileName);
            // Remove commas from the filename
            // Commas are used as separators in the Project Images list.
            // Read more in Project class.
            fileName = fileName.Replace(",", "");
            project.Images.Add("~/Images/" + fileName);
            fileName = Path.Combine(serverMapPath, fileName);
            project.ImageFile.SaveAs(fileName);

            _projectRepository.Add(project);
        }

        public void Remove(Project project)
        {
            _projectRepository.Remove(project);
        }
    }
}