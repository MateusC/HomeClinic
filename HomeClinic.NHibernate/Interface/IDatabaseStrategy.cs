using FluentNHibernate.Cfg.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeClinic.NHibernate.Interface
{
    public interface IDatabaseStrategy
    {
        IPersistenceConfigurer GetPersistenceConfigurer(String connectionString);
        void ExposeConfiguration(global::NHibernate.Cfg.Configuration config);
    }
}
