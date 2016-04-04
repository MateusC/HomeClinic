using HomeClinic.Domain.Entity;
using HomeClinic.NHibernate.Interface;

namespace HomeClinic.DAL.Interface
{
    public interface IPetRepository : IRepositoryBase<Pet>
    {
    }
}
