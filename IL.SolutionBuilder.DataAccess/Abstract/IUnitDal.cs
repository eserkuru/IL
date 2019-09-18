using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using IL.Core.DataAccess;
using IL.SolutionBuilder.Entities.ComplexTypes;
using IL.SolutionBuilder.Entities.Concrete;
using NHibernate.Criterion;

namespace IL.SolutionBuilder.DataAccess.Abstract
{
    public interface IUnitDal : IEntityRepository<Unit>
    {
        List<UnitProjects> GetUnitProjects(Expression<Func<UnitProjects, bool>> filter = null);
    }
}
