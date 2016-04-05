using FluentNHibernate.Cfg.Db;
using HomeClinic.NHibernate.Interface;

namespace HomeClinic.NHibernate.Context
{
    public abstract class DefaultDatabaseStrategy : IDatabaseStrategy
    {
        public virtual void ExposeConfiguration(global::NHibernate.Cfg.Configuration config) { }

        public abstract IPersistenceConfigurer GetPersistenceConfigurer(string connectionString);
    }
}
