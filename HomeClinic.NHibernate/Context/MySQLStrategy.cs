using FluentNHibernate.Cfg.Db;
using System;
using NHibernate.Connection;
using NHibernate.Driver;

namespace HomeClinic.NHibernate.Context
{
    class MySQLStrategy : DefaultDatabaseStrategy
    {
        public override IPersistenceConfigurer GetPersistenceConfigurer(String connectionString)
        {
            var configuration = MySQLConfiguration.Standard
                .ConnectionString(connectionString)
                .Driver<MySqlDataDriver>()
                .Provider<DriverConnectionProvider>();

            return configuration;
        }
    }
}
