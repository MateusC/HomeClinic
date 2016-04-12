//using HomeClinic.Service;
//using HomeClinic.Service.Interface;
using System.Windows.Forms;

namespace HomeClinic.Presentation
{
    public partial class HomeScreen : Form
    {
        //private IFacade _facade;
        public HomeScreen()
        {
            InitializeComponent();

            //aqui inicializa o facilitador que irá chamar os outros métodos.
            //_facade = Facade.Instance;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
