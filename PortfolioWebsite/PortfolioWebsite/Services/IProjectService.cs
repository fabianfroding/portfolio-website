﻿using PortfolioWebsite.Models;
using System.Collections.Generic;

namespace PortfolioWebsite.Services
{
    public interface IProjectService
    {
        Project GetById(int id);
        List<Project> GetAll();
        List<Project> GetAllByTitle(string title);
        void Add(Project project, string serverMapPath);
        void Remove(Project project);

        void Save(Project project, string serverMapPath);
    }
}