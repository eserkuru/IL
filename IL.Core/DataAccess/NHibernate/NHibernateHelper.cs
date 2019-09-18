using System;
using NHibernate;

namespace IL.Core.DataAccess.NHibernate
{
    /// <summary>
    /// Represents the class that supports the connection of Nhibernate technology.
    /// </summary>
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        /// <summary>
        /// Use it if you have a session factory, otherwise initialize a factory.
        /// </summary>
        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }

        /// <summary>
        /// The session creates the factory.
        /// </summary>
        protected abstract ISessionFactory InitializeFactory();

        /// <summary>
        /// Start the given session.
        /// </summary>
        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        /// <summary>
        /// The session is disposed.
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
