using System.Windows.Forms;
using System;

namespace Presentacion
{
    public partial class PMENU : Form
    {
        public PMENU()
        {
            InitializeComponent();
            BtnMedicos.Click += BtnMedicos_Click;
            BtnPacientes.Click += BtnPacientes_Click;
            BtnSalir.Click += BtnSalir_Click;
        }

        private void BtnMedicos_Click(object sender, EventArgs e)
        {
            PMedico formMedicos = new PMedico();
            formMedicos.Show();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            PPaciente formPaciente = new PPaciente();
            formPaciente.Show();
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
