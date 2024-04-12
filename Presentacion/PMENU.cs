using System.Windows.Forms;
using System;

namespace Presentacion
{
    public partial class PMENU : Form
    {
        public PMENU()
        {
            InitializeComponent();
            // Asociar el evento Click del botón BtnMedicos al método BtnMedicos_Click
            BtnMedicos.Click += BtnMedicos_Click;
            BtnSalir.Click += BtnSalir_Click;
        }

        private void BtnMedicos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario PMedicos
            PMedico formMedicos = new PMedico();
            formMedicos.Show();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de pacientes
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de citas
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
