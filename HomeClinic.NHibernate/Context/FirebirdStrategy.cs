using FluentNHibernate.Cfg.Db;
using System;
using NHibernate.Connection;
using NHibernate.Driver;
using FluentNHibernate.Cfg;

namespace HomeClinic.NHibernate.Context
{
    class MySQLStrategy : DefaultDatabaseStrategy
    {
        public override IPersistenceConfigurer GetPersistenceConfigurer(String connectionString)
        {
                return new Fluently.Configure()
                    .Database(MySQLConfiguration.Standard
                    .ConnectionString(connectionString))    
                    .Driver<MySqlDataDriver>()
                    .Provider<DriverConnectionProvider>();
            
        }
    }
}
