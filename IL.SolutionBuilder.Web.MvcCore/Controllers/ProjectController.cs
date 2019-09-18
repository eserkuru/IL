using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IL.SolutionBuilder.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IL.SolutionBuilder.Web.MvcCore.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly ISolutionService _solutionService;

        public ProjectController(IProjectService projectService, ISolutionService solutionService)
        {
            _projectService = projectService;
            _solutionService = solutionService;
        }

        // GET: Project
        public IActionResult Index()
        {
            return View();
        }

        // GET: Project/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Project/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult CreateFile(int id)
        {
            var solution = _solutionService.GetByProjectId(id);
            try
            {
                if (ModelState.IsValid)
                {
                    _projectService.CreateFile(id);
                }

                return RedirectToAction("Edit", "Solution", new { id = solution.Id });

            }
            catch
            {
                return RedirectToAction("Edit", "Solution", new { solutionidId = solution.Id });
            }
        }
    }
}