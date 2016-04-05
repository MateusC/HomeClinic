using FluentNHibernate.Mapping;

namespace HomeClinic.DAL.Mapping
{
    public class AbstractMap<T> : ClassMap<T>
    {
        public AbstractMap()
        {
            DynamicUpdate();
        }
    }
}
