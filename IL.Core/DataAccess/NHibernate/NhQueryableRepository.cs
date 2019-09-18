using System.Linq;
using IL.Core.Entities;

namespace IL.Core.DataAccess.NHibernate
{
    /// <summary>
    /// Represents the class that will allow querying from the database using nhibernate framework.
    /// </summary>
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private readonly NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;

        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        /// <summary>
        /// Returns the table to be subscribed to.
        /// </summary>
        public IQueryable<T> Table => Entities;

        /// <summary>
        /// Gets the entity to be queried from the session.
        /// </summary>
        protected virtual IQueryable<T> Entities => _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>());
    }
}
