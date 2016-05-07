using HomeClinic.Domain.Entity;
using System.Collections.Generic;

namespace HomeClinic.Service.Services
{
    public class PetService
    {
       // private static PetRepository _repository;

        private static PetService _instance;

        private PetService()
        {
          //  _repository = new PetRepository();
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
            return null;//_repository.GetAll().ToList();
        }

    }
}
