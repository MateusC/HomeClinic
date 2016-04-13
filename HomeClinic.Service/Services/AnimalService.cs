using HomeClinic.DAL.Repository;

namespace HomeClinic.Service.Services
{
    public class AnimalService
    {
        private static AnimalRepository _repository;

        private static AnimalService _instance;

        public static AnimalService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AnimalService();

                return _instance;
            }
        }

        private AnimalService()
        {
            _repository = AnimalRepository.Instance;
        }
    }
}
