using HomeClinic.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeClinic.Service.Interface
{
    public interface IFacade
    {
        //implementar os métodos que poderão ser chamados na tela.
        void Initialization();

        List<Pet> GetAllPets();
    }
}
