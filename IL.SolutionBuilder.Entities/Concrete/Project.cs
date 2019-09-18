using System.Collections.Generic;
using IL.SolutionBuilder.Entities.Abstract;
using IL.SolutionBuilder.Entities.Enums;

namespace IL.SolutionBuilder.Entities.Concrete
{
    public class Project : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public virtual SourceType SourceType { get; set; }
        public virtual string DirectoryName { get; set; }
        public virtual bool IsFileCreated { get; set; }
        public virtual Unit Unit { get; set; }
    }
}