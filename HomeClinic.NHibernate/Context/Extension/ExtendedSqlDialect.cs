using NHibernate.Dialect;

namespace HomeClinic.NHibernate.Context.Extension
{
    class ExtendedSqlDialect : MsSql2012Dialect
    {
        public override bool SupportsUnique
        {
            get { return true; }
        }
    }
}
