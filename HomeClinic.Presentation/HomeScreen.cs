using HomeClinic.Domain.DTO;
using HomeClinic.Service;
using HomeClinic.Service.Interface;
using System;
using System.Windows.Forms;

namespace HomeClinic.Presentation
{
    public partial class HomeScreen : Form
    {
        private IFacade _facade;
        public HomeScreen()
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

        private void petToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ControlPet());
        }

        private void tosaToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ControlPerson());
        }

        private void veterinárioToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ControlPerson());
        }
    }
}
