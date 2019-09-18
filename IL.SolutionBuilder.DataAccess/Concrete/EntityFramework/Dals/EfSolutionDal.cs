using IL.Core.DataAccess.EntityFramework;
using IL.SolutionBuilder.DataAccess.Abstract;
using IL.SolutionBuilder.DataAccess.Concrete.EntityFramework.Contexts;
using IL.SolutionBuilder.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using FluentNHibernate.Utils;
using Microsoft.EntityFrameworkCore;
using NHibernate.Engine.Query;
using NHibernate.Proxy;

namespace IL.SolutionBuilder.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfSolutionDal<T> : EfEntityReporsitoryBase<Solution, T>, ISolutionDal where T : DbContext, new()
    {
        public Solution GetWithProjectId(int projectId)
        {
            using (var context = new T())
            {
                var result = context.Set<Project>()
                    .Where(p => p.Id == projectId)
                    .Join(context.Set<Unit>(),
                        p => p.Unit.Id,
                        u => u.Id,
                        (p, u) => new { P = p, U = u })
                    .Join(context.Set<Solution>(),
                        pu => pu.U.Solution.Id,
                        s => s.Id,
                        (pu, s) => new { PU = pu, S = s })
                    .Select(y => y.S).SingleOrDefault();

                return result;
            }
        }

        public Solution GetWithUnitId(int unitId)
        {
            using (var context = new T())
            {
                var result = context.Set<Unit>()
                    .Where(u => u.Id == unitId)
                    .Join(context.Set<Solution>(),
                        u => u.Solution.Id,
                        s => s.Id,
                        (u, s) => new {U = u, S = s})
                    .Select(x => x.S).SingleOrDefault();

                return result;
            }
        }
    }
}


