using FluentNHibernate.Cfg.Db;
using System;
using NHibernate.Connection;
using NHibernate.Driver;

namespace HomeClinic.NHibernate.Context
{
    class FirebirdStrategy : DefaultDatabaseStrategy
    {
        public override IPersistenceConfigurer GetPersistenceConfigurer(String connectionString)
        {
            return new FirebirdConfiguration().ConnectionString(connectionString)
                .Driver<FirebirdClientDriver>()
                .Provider<DriverConnectionProvider>();

        }
    }
}
