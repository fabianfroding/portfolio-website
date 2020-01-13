﻿using System;
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
            System.Diagnostics.Debug.WriteLine("Service GetById: " + _projectRepository.GetById(id).Images.Count.ToString());
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
            project.ImagePath = "~/Images/" + fileName;
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