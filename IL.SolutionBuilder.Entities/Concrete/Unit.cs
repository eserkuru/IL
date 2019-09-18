using System;
using System.Collections.Generic;
using System.Text;
using IL.Core.Entities;
using IL.SolutionBuilder.Entities.Abstract;
using IL.SolutionBuilder.Entities.Enums;

namespace IL.SolutionBuilder.Entities.Concrete
{
    public class Unit : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual SourceType SourceType { get; set; }
        public virtual string Description { get; set; }
        public virtual Solution Solution { get; set; }
    }
}
