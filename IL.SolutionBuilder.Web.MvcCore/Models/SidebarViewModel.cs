using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Web.MvcCore.Models
{
    public class SidebarViewModel
    {
        public Entities.Concrete.Solution Solution { get; set; }
        public List<Entities.Concrete.Unit> Units { get; set; }
        public List<Project> Projects { get; set; }
    }
}
