using IL.SolutionBuilder.Entities.Abstract;

namespace IL.SolutionBuilder.Entities.Concrete
{
    public class Entity : EntityBase
    {
        public virtual string Name { get; set; }
        public Solution Solution { get; set; }
    }
}
