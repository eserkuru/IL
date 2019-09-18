using System.Net.Mime;
using IL.SolutionBuilder.Entities.Abstract;

namespace IL.SolutionBuilder.Entities.Concrete
{
    public class Solution : EntityBase
    {
        public virtual string CompanyName { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual string Description { get; set; }
        public virtual string LongDescription{ get; set; }
        public virtual string DirectoryName { get; set; }
        public virtual bool IsFileCreated { get; set; }
    }
}
