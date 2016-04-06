using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeClinic.Presentation
{
    public partial class ControlPet : UserControl
    {
        public ControlPet()
        {
            InitializeComponent();
        }

        private void dtpDateOfBirth_Leave(object sender, EventArgs e)
        {
            txtAges.Text = CalculateAges(Convert.ToDateTime(dtpDateOfBirth.Text));
        }

        //PASSAR O METODO PARA O LUGAR CERTO
        public static string CalculateAges(DateTime dateOfBirth)
        {
            string ages = string.Empty;
            int years = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.Month < dateOfBirth.Month || (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day))
                years--;            
            ages += years + " anos";                        

            return ages;

        }

        private void RegisterPet_Load(object sender, EventArgs e)
        {
            //se estiver cadastrando ou editando visible true para btn Save
            //senão visible true para btn editar e historico de consultas e vacinas
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnVaccinesHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnAppointmentHistory_Click(object sender, EventArgs e)
        {

        }       
    }
}
