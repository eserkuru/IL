using IL.SolutionBuilder.Business.Abstract;
using IL.SolutionBuilder.Entities.Concrete;
using IL.SolutionBuilder.Entities.Enums;
using IL.SolutionBuilder.Web.MvcCore.Models.Unit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IL.SolutionBuilder.Web.MvcCore.Controllers
{
    public class UnitController : Controller
    {
        private readonly ISolutionService _solutionService;
        private readonly IUnitService _unitService;
        private readonly IProjectService _projectService;

        public UnitController(ISolutionService solutionService, IUnitService unitService, IProjectService projectService)
        {
            _solutionService = solutionService;
            _unitService = unitService;
            _projectService = projectService;
        }


        // GET: Unit/Create
        public IActionResult Create(int solutionId)
        {

            var model = new AddViewModel
            {
                Solution = _solutionService.GetById(solutionId),
                Unit = new Unit()
            };

            return View(model);
        }

        // POST: Unit/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Unit unit)
        {
            unit.SourceType = SourceType.Custom;
            try
            {
                _unitService.Add(unit);

                return RedirectToAction("Edit", "Unit", new { id = unit.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Unit/Edit/5
        public IActionResult Edit(int id)
        {
            var model = new UpdateViewModel
            {
                Solution = _solutionService.GetByUnitId(id),
                Unit = _unitService.GetById(id),
                Projects = _projectService.GetListByUnitId(id)
            };
            return View(model);
        }

        // POST: Unit/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Unit unit)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _unitService.Update(unit);
                }

                return RedirectToAction("Edit", "Unit", new { id = unit.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Unit/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Unit/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Edit", "Solution");
            }
            catch
            {
                return View();
            }
        }
    }
}