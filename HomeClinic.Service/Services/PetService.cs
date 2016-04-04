using HomeClinic.DAL.Repository;
using HomeClinic.Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace HomeClinic.Service.Services
{
    public class PetService
    {
        private static PetRepository _repository;

        private static PetService _instance;

        private PetService()
        {
            _repository = PetRepository.Instance;
        }

        public static PetService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PetService();

                return _instance;
            }
        }

        public List<Pet> GetAll()
        {
            return _repository.GetAll().ToList();
        }

    }
}
