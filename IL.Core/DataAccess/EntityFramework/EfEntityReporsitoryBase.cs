using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using IL.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace IL.Core.DataAccess.EntityFramework
{
    public class EfEntityReporsitoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
         where TContext : DbContext, new()
    {
        /// <summary>
        /// Adds the given entity to the database using entity framework core.
        /// </summary>
        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            return entity;
        }

        /// <summary>
        /// Returns a single record of the given entity from the database using entity framework core.
        /// </summary>
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter ?? throw new ArgumentNullException(nameof(filter)));
            }
        }

        /// <summary>
        /// Returns the list record of the given entity from the database using entity framework core.
        /// </summary>
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        /// <summary>
        /// Removes the given entity from the database using entity framework core.
        /// </summary>
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var removedEntity = context.Entry(entity);
                removedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates the given entity in the database using entity framework core.
        /// </summary>
        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
            return entity;
        }
    }
}
