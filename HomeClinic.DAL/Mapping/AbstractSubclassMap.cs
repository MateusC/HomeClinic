using FluentNHibernate.Mapping;

namespace HomeClinic.DAL.Mapping
{
    public class AbstractSubclassMap<T> : SubclassMap<T>
    {
        public AbstractSubclassMap()
        {
            DynamicUpdate();
        }
    }
}
