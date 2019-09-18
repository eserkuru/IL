using System.Collections.Generic;
using IL.SolutionBuilder.Entities.ComplexTypes;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Web.MvcCore.Models.Solution
{
    public class DetailViewModel
    {
        public Entities.Concrete.Solution Solution { get; set; }
        public int CurrentUnit { get; set; }
        public List<Entities.Concrete.Unit> Units { get; set; }
        public List<Project> Projects { get; set; }
    }
}
