using FluentNHibernate.Cfg.Db;
using HomeClinic.NHibernate.Context.Extension;
using System;

namespace HomeClinic.NHibernate.Context
{
    public class SqlStrategy : DefaultDatabaseStrategy
    {
        public override IPersistenceConfigurer GetPersistenceConfigurer(String connectionString)
        {
            return MsSqlConfiguration.MsSql2005.IsolationLevel(System.Data.IsolationLevel.ReadUncommitted)
                       .ConnectionString(connectionString)
                       .ShowSql()
                       .Dialect<ExtendedSqlDialect>();
        }
    }
}
