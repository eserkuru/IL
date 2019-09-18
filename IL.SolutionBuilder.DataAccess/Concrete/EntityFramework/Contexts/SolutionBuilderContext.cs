using IL.SolutionBuilder.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace IL.SolutionBuilder.DataAccess.Concrete.EntityFramework.Contexts
{
    public class SolutionBuilderContext : DbContext
    {
        public SolutionBuilderContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=SolutionBuilder;Integrated Security=True;MultipleActiveResultSets=True");
        }

        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
