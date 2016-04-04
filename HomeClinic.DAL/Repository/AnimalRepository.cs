using HomeClinic.DAL.Interface;
using HomeClinic.Domain.Entity;
using HomeClinic.NHibernate.RepositoryBase;

namespace HomeClinic.DAL.Repository
{
    public class PetRepository : RepositoryBase<Pet>, IPetRepository
    {
        private static PetRepository _instance;

        private PetRepository() { /*somente para não ser instanciado fora daqui.*/ }

        public static PetRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PetRepository();

                return _instance;
            }
        }
    }
}
