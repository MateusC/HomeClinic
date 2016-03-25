using HomeClinic.Service;
using HomeClinic.Service.Interface;
using System.Windows.Forms;

namespace HomeClinic.Presentation
{
    public partial class Form1 : Form
    {
        private Facade _facade;
        public Form1()
        {
            InitializeComponent();

            //aqui inicializa o facilitador que irá chamar os outros métodos.
            _facade = Facade.Instance;
        }
    }
}
