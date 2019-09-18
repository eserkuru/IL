using System;
using System.Collections.Generic;
using System.Text;
using IL.Core.DataAccess;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.DataAccess.Abstract
{
    public interface IProjectDal : IEntityRepository<Project>
    {
        List<Project> GetListBySolution(int solutionId);
    }
}
