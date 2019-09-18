using System;
using System.Linq;
using IL.SolutionBuilder.Business.Abstract;
using IL.SolutionBuilder.Entities.Concrete;
using IL.SolutionBuilder.Web.MvcCore.Models;
using IL.SolutionBuilder.Web.MvcCore.Models.Solution;
using Microsoft.AspNetCore.Mvc;

namespace IL.SolutionBuilder.Web.MvcCore.Controllers
{
    public class SolutionController : Controller
    {
        private readonly ISolutionService _solutionService;
        private readonly IUnitService _unitService;
        private readonly IProjectService _projectService;

        public SolutionController(ISolutionService solutionService, IProjectService projectService, IUnitService unitService)
        {
            _solutionService = solutionService;
            _projectService = projectService;
            _unitService = unitService;
        }

        // GET: Solution
        public IActionResult Index()
        {
            var model = new ListViewModel()
            {
                Solutions = _solutionService.GetAll()
            };
            return View(model);
        }

        // GET: Solution/Details/5
        public IActionResult Details(int solutionId, int unitId=0)
        {
            var model = new DetailViewModel
            {
                Solution = _solutionService.GetById(solutionId),
                Units = _unitService.GetListBySolution(solutionId),
                Projects = _projectService.GetListBySolutionId(solutionId)
            };
            return View(model);
        }

        // GET: Solution/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Solution/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddViewModel model)
        {
            try
            {
                if (model.DefaultProject)
                {
                    _solutionService.AddWithDefaultProject(model.Solution);
                }
                else
                {
                    _solutionService.Add(model.Solution);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Solution/Edit/5
        public IActionResult Edit(int id)
        {
            var model = new UpdateViewModel
            {
                Solution = _solutionService.GetById(id),
                Units = _unitService.GetListBySolution(id),
                Projects = _projectService.GetListBySolutionId(id)
            };
            return View(model);
        }

        // POST: Solution/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Solution solution)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _solutionService.Update(solution);
                }

                return RedirectToAction("Edit", "Solution", new { id = solution.Id });
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Solution/Delete/5
        public IActionResult Delete()
        {
            return View();
        }

        // POST: Solution/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _solutionService.Delete(id);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Solution/CreateSolutionFile/5
        public IActionResult CreateFile(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _solutionService.CreateFile(id);
                }

                return RedirectToAction("Details", "Solution", new { solutionId = id });

            }
            catch
            {
                return RedirectToAction("Details", "Solution", new { solutionId = id });
            }
        }
    }
}