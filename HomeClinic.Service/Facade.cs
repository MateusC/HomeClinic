using HomeClinic.Service.Interface;
using HomeClinic.Service.Services;

namespace HomeClinic.Service
{
    public class Facade : IFacade
    {
        private AnimalService _animalService;

        private static Facade _instance;

        public static Facade Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Facade();

                return _instance;
            }
        }

        private Facade()
        {
            _animalService = AnimalService.Instance;
        }
    }
}
