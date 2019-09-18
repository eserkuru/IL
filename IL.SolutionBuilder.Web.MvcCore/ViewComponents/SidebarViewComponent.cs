using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IL.SolutionBuilder.Business.Abstract;
using IL.SolutionBuilder.Web.MvcCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IL.SolutionBuilder.Web.MvcCore.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly ISolutionService _solutionService;
        private readonly IUnitService _unitService;
        private readonly IProjectService _projectService;

        public SidebarViewComponent(ISolutionService solutionService, IUnitService unitService, IProjectService projectService)
        {
            _solutionService = solutionService;
            _unitService = unitService;
            _projectService = projectService;
        }

        public ViewViewComponentResult Invoke(int solutionId)
        {
            solutionId = Convert.ToInt32(HttpContext.Request.Query["solutionId"]);
            var model = new SidebarViewModel
            {
                Solution = _solutionService.GetById(solutionId),
                Units = _unitService.GetListBySolution(solutionId),
                Projects = _projectService.GetListBySolutionId(solutionId)
            };
            return View(model);
        }
    }
}
