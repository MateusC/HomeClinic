using FluentNHibernate.Cfg;
using HomeClinic.Domain.Enum;
using HomeClinic.NHibernate.Context;
using HomeClinic.NHibernate.Interface;
using NHibernate;
using NHibernate.Context;
using NHibernate.Engine;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeClinic.NHibernate
{
    public class NHibernateContext
    {
        static NHibernateContext()
        {
            _factories = new Dictionary<String, ISessionFactory>();
        }

        [ThreadStatic]
        private static EnumDataBaseProvider _provider;

        public static Dictionary<String, ISessionFactory> _factories;

        [ThreadStatic]
        static IDatabaseStrategy _databaseStrategy;

        [ThreadStatic]
        static CurrentSessionContext _context;

        [ThreadStatic]
        static ISessionFactory _factory;

        public static CurrentSessionContext CurrentContext { get { return _context; } }

        public static Int32 CurrentProvider { get { return _provider.GetHashCode(); } }

        public static ISessionFactory GetFactory(DatabaseConfig config)
        {
            if (!_factories.TryGetValue(config.ConnectionString, out _factory))
            {
                _factory = GetNewFactory(config);

                _context = new ThreadStaticSessionContext(_factory as ISessionFactoryImplementor);
            }
            else
            {
                _factory = _factories.Where(x => x.Key == config.ConnectionString).Select(x => x.Value).FirstOrDefault();

                _context = new ThreadStaticSessionContext(_factory as ISessionFactoryImplementor);
            }

            return _factory;
        }

        private static ISessionFactory GetNewFactory(DatabaseConfig config)
        {

            lock (_factories)
            {
                SetStrategyPattern((EnumDataBaseProvider)config.Provider);

                var factory = CreateSessionFactory(config);

                _factories.Add(config.ConnectionString, factory);

                return factory;
            }
        }

        private static void SetStrategyPattern(EnumDataBaseProvider provider)
        {
            switch (provider)
            {
                case EnumDataBaseProvider.Sql:
                    _databaseStrategy = new SqlStrategy();
                    break;

                case EnumDataBaseProvider.Firebird:
                    _databaseStrategy = new FirebirdStrategy();
                    break;
            }

            _provider = provider;
        }

        private static ISessionFactory CreateSessionFactory(DatabaseConfig config)
        {
            try
            {
                return Fluently.Configure()
                                    .Database(
                                        _databaseStrategy.GetPersistenceConfigurer(config.ConnectionString)
                                    )
                                    .Mappings(m =>
                                    {
                                        m.FluentMappings.AddFromAssembly(config.Assembly).Conventions.AddAssembly(config.Assembly);
                                    })
                                    .ExposeConfiguration(NHibernateConfig =>
                                    {
                                        NHibernateConfig.SetProperty("current_session_context_class", "thread_static");

                                        _databaseStrategy.ExposeConfiguration(NHibernateConfig);

                                        new SchemaUpdate(NHibernateConfig).Execute(false, true);
                                    })
                                    .BuildSessionFactory();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar o contexto com o banco de dados.", ex);
            }
        }
    }
}
