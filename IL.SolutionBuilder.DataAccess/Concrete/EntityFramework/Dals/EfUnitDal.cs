using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using IL.Core.DataAccess.EntityFramework;
using IL.SolutionBuilder.DataAccess.Abstract;
using IL.SolutionBuilder.Entities.ComplexTypes;
using IL.SolutionBuilder.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using NHibernate.Hql.Ast.ANTLR.Tree;
using NHibernate.Linq;
using Remotion.Linq.Clauses.ResultOperators;

namespace IL.SolutionBuilder.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfUnitDal<T> : EfEntityReporsitoryBase<Unit, T>, IUnitDal where T : DbContext, new()
    {
        public List<UnitProjects> GetUnitProjects(Expression<Func<UnitProjects, bool>> filter = null)
        {
            using (var context = new T())
            {
                var result = from project in context.Set<Project>()
                             join unit in context.Set<Unit>() on project.Unit.Id equals unit.Id
                             select new UnitProjects()
                             {
                                 Solution = unit.Solution,
                                 Unit = unit,
                                 UnitName = unit.Name,
                                 UnitSourceType = unit.SourceType,
                                 UnitDescription = unit.Description,
                                 Project = project,
                                 ProjectName = project.Name,
                                 ProjectSourceType = project.SourceType,
                                 ProjectType = project.ProjectType,
                                 DirectoryName = project.DirectoryName,
                                 IsFileCreated = project.IsFileCreated
                             };

                return filter != null 
                    ? result.Where(filter).ToList() 
                    : result.ToList();
            }
        }

    }
}
