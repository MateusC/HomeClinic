using HomeClinic.DAL.Interface;

namespace HomeClinic.DAL.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private static AnimalRepository _instance;

        public static AnimalRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AnimalRepository();

                return _instance;
            }
        }

        private AnimalRepository()
        {
            //construtor da repositorio.
        }
    }
}
