using System;
using System.Reflection;

namespace HomeClinic.NHibernate
{
    public class DatabaseConfig
    {
        public String ConnectionString { get; set; }
        public Int32 Provider { get; set; }
        public Assembly Assembly { get; set; }

        public DatabaseConfig(String connectionString, Int32 provider, Assembly assembly)
        {
            ConnectionString = connectionString;
            Provider = provider;
            Assembly = assembly;
        }

        public override String ToString()
        {
            return String.Format("Assembly: {0}, Provider: {1}, Connection: {2}", Assembly.FullName, Provider, ConnectionString);
        }
    }
}
