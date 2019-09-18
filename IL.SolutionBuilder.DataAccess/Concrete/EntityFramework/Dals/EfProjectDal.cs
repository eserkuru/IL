using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using IL.Core.DataAccess.EntityFramework;
using IL.SolutionBuilder.DataAccess.Abstract;
using IL.SolutionBuilder.Entities.Concrete;
using IL.SolutionBuilder.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace IL.SolutionBuilder.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfProjectDal<T> : EfEntityReporsitoryBase<Project, T>, IProjectDal where T : DbContext, new()
    {
        public List<Project> GetListBySolution(int solutionId)
        {
            using (var context = new T())
            {
                var result = (context.Set<Unit>()
                    .Join(context.Set<Project>(), u => u.Id, p => p.Unit.Id, (u, p) => new { u, p })
                    .Where(@t => @t.u.Solution.Id == solutionId)
                    .Select(@t => new Project()
                    {
                        Id = @t.p.Id,
                        Unit = @t.u,
                        IsFileCreated = @t.p.IsFileCreated,
                        Name = @t.p.Name,
                        DirectoryName = @t.p.DirectoryName,
                        ProjectType = @t.p.ProjectType,
                        SourceType = @t.p.SourceType,
                        IsDeleted = @t.p.IsDeleted,
                        Created = @t.p.Created,
                        CreatedBy = @t.p.CreatedBy,
                        Modified = @t.p.Modified,
                        ModifiedBy = @t.p.ModifiedBy
                    })).ToList();

                return result;
            }
        }
    }
}
