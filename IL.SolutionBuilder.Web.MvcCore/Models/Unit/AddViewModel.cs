using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IL.SolutionBuilder.Web.MvcCore.Models.Unit
{
    public class AddViewModel
    {
        public Entities.Concrete.Unit Unit { get; set; }
        public Entities.Concrete.Solution Solution { get; set; }
    }
}
