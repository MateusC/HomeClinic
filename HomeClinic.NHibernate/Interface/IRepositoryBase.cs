using System.Linq;

namespace HomeClinic.NHibernateNHibernate.Interface
{
    public interface IRepositoryBase<T>
    {
        T Update(T component);

        T Insert(T component);

        void Delete(T component);

        IQueryable<T> GetAll();
    }
}
