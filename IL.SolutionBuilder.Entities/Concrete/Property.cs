using System;
using System.Collections.Generic;
using System.Text;
using IL.SolutionBuilder.Entities.Abstract;

namespace IL.SolutionBuilder.Entities.Concrete
{
    public class Property : EntityBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Entity Entities { get; set; }
    }
}
