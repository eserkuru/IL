using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using IL.Core.Entities;

namespace IL.Core.DataAccess.NHibernate
{
    public class NhEntityRepositortyBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly NHibernateHelper _nHibernateHelper;

        public NhEntityRepositortyBase(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        /// <summary>
        /// Adds the given entity to the database using nhibernate framework.
        /// </summary>
        public TEntity Add(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        /// <summary>
        /// Mark the IsDeleted field of the given entity correctly in the database using nhibernate framework.
        /// </summary>
        public void Delete(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
            }
        }

        /// <summary>
        /// Returns a single record of the given entity from the database using nhibernate framework.
        /// </summary>
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter ?? throw new ArgumentNullException(nameof(filter)));
            }
        }

        /// <summary>
        /// Returns the list record of the given entity from the database using nhibernate framework.
        /// </summary>
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return filter == null
                    ? session.Query<TEntity>().ToList()
                    : session.Query<TEntity>().Where(filter).ToList();
            }
        }

        /// <summary>
        /// Removes the given entity from the database using nhibernate framework.
        /// </summary>
        public void Remove(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Delete(entity);
            }
        }

        /// <summary>
        /// Updates the given entity in the database using nhibernate framework.
        /// </summary>
        public TEntity Update(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }
    }
}
