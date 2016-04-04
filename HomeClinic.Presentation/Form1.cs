using HomeClinic.Service;
using HomeClinic.Service.Interface;
using System.Windows.Forms;
using System;
using HomeClinic.Domain.DTO;

namespace HomeClinic.Presentation
{
    public partial class Form1 : Form
    {
        private IFacade _facade;

        public Form1()
        {
            InitializeComponent();

            //método responsável por iniciar a conexão com o banco e os serviços
            Initialize();
        }

        private void Initialize()
        {
            ConfigurationXml xml = ConfigurationXml.GetDatabaseConfig(Environment.CurrentDirectory);

            _facade = Facade.GetInstance(xml);

            _facade.Initialization();

            var pets = _facade.GetAllPets();
        }
    }
}
