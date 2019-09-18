using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using IL.Core.DataAccess;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.DataAccess.Abstract
{
    public interface ISolutionDal : IEntityRepository<Solution>
    {
        Solution GetWithProjectId(int projectId);
        Solution GetWithUnitId(int unitId);
    }
}
