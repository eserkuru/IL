using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Web.MvcCore.Models.Unit
{
    public class UpdateViewModel
    {
        public Entities.Concrete.Unit Unit { get; set; }
        public List<Project> Projects { get; set; }
        public Entities.Concrete.Solution Solution { get; set; }
    }
}
