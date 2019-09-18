using System;
using System.Collections.Generic;
using System.Text;
using IL.SolutionBuilder.Entities.Concrete;
using IL.SolutionBuilder.Entities.Enums;

namespace IL.SolutionBuilder.Entities.ComplexTypes
{
    public class UnitProjects
    {
        public virtual Solution Solution { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual string UnitName { get; set; }
        public virtual SourceType UnitSourceType { get; set; }
        public virtual string UnitDescription { get; set; }
        public virtual Project Project { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public virtual SourceType ProjectSourceType{ get; set; }
        public virtual string DirectoryName { get; set; }
        public virtual bool IsFileCreated { get; set; }
    }
}
