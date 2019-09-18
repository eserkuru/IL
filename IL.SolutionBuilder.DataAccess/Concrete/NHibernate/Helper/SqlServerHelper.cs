using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using IL.Core.DataAccess.NHibernate;
using NHibernate;

namespace IL.SolutionBuilder.DataAccess.Concrete.NHibernate.Helper
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(
                        @"Data Source=.;Initial Catalog=SolutionBuilder;Integrated Security=True;MultipleActiveResultSets=True")
                    .ShowSql()).Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }
    }
}
