using HomeClinic.Service.Interface;
using HomeClinic.Service.Services;
using HomeClinic.Domain.DTO;
using HomeClinic.Domain.Entity;
using System.Collections.Generic;
using HomeClinic.NHibernate;
using Microsoft.Practices.Unity.InterceptionExtension;
using HomeClinic.DAL.Mapping;

namespace HomeClinic.Service
{
    public class Facade : IFacade
    {
        private PetService _petService;

        private Facade() { /*somente para não ser instanciado fora daqui.*/ }

        public static IFacade GetInstance(ConfigurationXml xmlConfig)
        {
            //montar instancia do banco

            DatabaseConfig config = new DatabaseConfig(xmlConfig.ConnectionString, xmlConfig.Provider, typeof(AbstractMap<>).Assembly);

            var factory = NHibernateContext.GetFactory(config);

            IFacade facade = Intercept.ThroughProxy<IFacade>(new Facade(), new InterfaceInterceptor(), new[] { new NHibernateSessionManager(factory) });

            return null; //facade
        }

        public List<Pet> GetAllPets()
        {
            return _petService.GetAll();
        }

        public void Initialization()
        {
            _petService = PetService.Instance;
        }
    }
}
