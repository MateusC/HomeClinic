using System.Linq;

namespace HomeClinic.NHibernate.Interface
{
    public interface IRepositoryBase<T>
    {
        T Update(T component);

        T Insert(T component);

        void Delete(T component);

        IQueryable<T> GetAll();
    }
}
