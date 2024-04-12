using Datos.Base_de_datos;
using Datos.Entidades;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PCita : Form
    {
        public PCita()
        {
            InitializeComponent();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnCerrar.Click += BtnCerrar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            CBXCMedico.SelectedIndexChanged += CBXCMedico_SelectedIndexChanged;
            CBXCPaciente.SelectedIndexChanged += CBXPaciente_SelectedIndexChanged;
            DGVCita.CellDoubleClick += DGVCita_CellDoubleClick;
            citasBindingSource.Filter = "Estado = true";


        }

        private void PCita_Load(object sender, EventArgs e)
        {
           //((DataTable)cONSULTORIORADDataSet8.Citas).DefaultView.RowFilter = "Estado = true";
            CargarDatosEstadoActivo();

            CBXFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();
            // TODO: esta línea de código carga datos en la tabla 'cONSULTORIORADDataSet8.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.cONSULTORIORADDataSet8.Citas);
            
            TxtId.Text = ObtenerSiguienteId().ToString();

            using (var connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
            {
                connection.Open();
                string query = "SELECT MedicoId, Nombre + ' ' + Apellidos AS NombreApellido FROM Medicos WHERE Estado = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CBXCMedico.DropDownStyle = ComboBoxStyle.DropDownList;
                CBXCMedico.DisplayMember = "MedicoId"; 
                CBXCMedico.ValueMember = "MedicoId";
                CBXCMedico.DataSource = dt;
            }

            using (var connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
            {
                connection.Open();
                string query = "SELECT PacienteId, Nombre + ' ' + Apellidos AS NombreApellido FROM Pacientes WHERE Estado = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CBXCPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
                CBXCPaciente.DisplayMember = "PacienteId";
                CBXCPaciente.ValueMember = "PacienteId";
                CBXCPaciente.DataSource = dt;
            }
        }

        private void DGVCita_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVCita.Rows[e.RowIndex];

                // Obtener el ID de la cita seleccionada
                TxtId.Text = row.Cells[0].Value.ToString();
                CBXCMedico.Text = row.Cells[1].Value.ToString();
                CBXCPaciente.Text = row.Cells[2].Value.ToString();
                DateTime fechaIngreso;
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out fechaIngreso))
                {
                   DTPFechaCita.Value = fechaIngreso;
                }
                if (row.Cells[4].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    if (row.Cells[4].Value.ToString().Equals("True", StringComparison.OrdinalIgnoreCase))
                    {
                        CBActivo.Checked = true;
                    }
                    else if (row.Cells[4].Value.ToString().Equals("False", StringComparison.OrdinalIgnoreCase))
                    {
                        CBActivo.Checked = false;
                    }
                }

            }
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el médico seleccionado en el ComboBox
            var medicoSeleccionado = (DataRowView)CBXCMedico.SelectedItem;
            int medicoId = Convert.ToInt32(medicoSeleccionado["MedicoId"]);

            // Obtener el paciente seleccionado en el ComboBox
            var pacienteSeleccionado = (DataRowView)CBXCPaciente.SelectedItem;
            int pacienteId = Convert.ToInt32(pacienteSeleccionado["PacienteId"]);

            // Obtener la fecha de la cita
            DateTime fechaCita = DTPFechaCita.Value;

            // Mostrar un cuadro de diálogo de confirmación
            string mensaje = $"¿Desea guardar la cita para el médico {medicoId} y el paciente {pacienteId} en la fecha {fechaCita}?";
            DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Crear la conexión a la base de datos
                using (var connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
                {
                    connection.Open();

                    // Crear la consulta SQL para insertar la cita
                    string query = "INSERT INTO Citas (MedicoId, PacienteId, FechaCita, Estado) VALUES (@MedicoId, @PacienteId, @FechaCita, @Estado)";
                    bool estado = CBActivo.Checked;

                    // Crear y configurar el comando SQL
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicoId", medicoId);
                        command.Parameters.AddWithValue("@PacienteId", pacienteId);
                        command.Parameters.AddWithValue("@FechaCita", fechaCita);
                        command.Parameters.AddWithValue("@Estado", estado); 

                        // Ejecutar el comando SQL
                        command.ExecuteNonQuery();

                        // Mostrar un mensaje de éxito
                        MessageBox.Show("La cita se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TxtId.Text = ObtenerSiguienteId().ToString();
                        this.citasTableAdapter.Fill(this.cONSULTORIORADDataSet8.Citas);

                        LimpiarCampos();
                    }
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DGVCita.SelectedRows.Count == 1)
            {
                // Obtener los datos de la cita a modificar
                int idcita = int.Parse(TxtId.Text);
                var medicoSeleccionado = (DataRowView)CBXCMedico.SelectedItem;
                int medicoId = Convert.ToInt32(medicoSeleccionado["MedicoId"]);
                var pacienteSeleccionado = (DataRowView)CBXCPaciente.SelectedItem;
                int pacienteId = Convert.ToInt32(pacienteSeleccionado["PacienteId"]);
                DateTime fechaCita = DTPFechaCita.Value;
                bool estado = CBActivo.Checked;

                // Mostrar un cuadro de diálogo de confirmación
                var confirmacion = MessageBox.Show("¿Está seguro de que desea modificar la cita?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Actualizar la cita en la base de datos
                    using (var connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
                    {
                        connection.Open();
                        string query = "UPDATE Citas SET MedicoId = @MedicoId, PacienteId = @PacienteId, FechaCita = @FechaCita, Estado = @Estado WHERE CitaId = @CitaId";

                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MedicoId", medicoId);
                            command.Parameters.AddWithValue("@PacienteId", pacienteId);
                            command.Parameters.AddWithValue("@FechaCita", fechaCita);
                            command.Parameters.AddWithValue("@Estado", estado);
                            command.Parameters.AddWithValue("@CitaId", idcita);

                            command.ExecuteNonQuery();
                            
                        }
                    }

                    // Mostrar mensaje de éxito y actualizar el DataGridView
                    MessageBox.Show("La cita se ha modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.citasTableAdapter.Fill(this.cONSULTORIORADDataSet8.Citas);
                    LimpiarCampos();
                    
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cita para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVCita.SelectedRows.Count > 0)
            {
                // Obtener el ID de la cita seleccionada
                int idCita = Convert.ToInt32(DGVCita.SelectedRows[0].Cells[0].Value);

                // Crear el mensaje de confirmación
                string mensaje = "¿Desea eliminar la cita seleccionada?";

                // Mostrar el cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar si el usuario confirmó la acción
                if (resultado == DialogResult.Yes)
                {
                    // Actualizar el estado de la cita a false
                    string query = "UPDATE Citas SET Estado = 0 WHERE CitaId = @CitaId";

                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CitaId", idCita);
                            command.ExecuteNonQuery();
                        }
                    }
                    this.citasTableAdapter.Fill(this.cONSULTORIORADDataSet8.Citas);
                    LimpiarCampos();
                }
            }
        }



        private int ObtenerSiguienteId()
        {
            int siguienteId = 0;

            // Crear la cadena SQL para obtener el máximo ID actual
            string query = "SELECT ISNULL(MAX(CitaId), 0) FROM Citas";

            // Crear la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ejecutar el comando y obtener el resultado
                    object result = command.ExecuteScalar();

                    // Verificar si el resultado es válido y convertirlo a entero
                    if (result != null && result != DBNull.Value)
                    {
                        siguienteId = Convert.ToInt32(result);
                    }
                }
            }

            // Incrementar el ID obtenido para obtener el siguiente ID
            siguienteId++;

            return siguienteId;
        }

        private void CBXFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el filtro seleccionado
            string filtro = CBXFiltro.SelectedItem.ToString();

            // Actualizar el DataGridView según el filtro seleccionado
            if (filtro == "Activos")
            {
                CargarDatosEstadoActivo();
            }
            else if (filtro == "No Activos")
            {
                CargarDatosEstadoNoActivo();
            }
        }
        private void CBXCMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCMedico.SelectedItem != null)
            {
                var medicoSeleccionado = (DataRowView)CBXCMedico.SelectedItem;
                TxtNombreMedico.Text = medicoSeleccionado["NombreApellido"].ToString();
            }
        }

        private void CBXPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCPaciente.SelectedItem != null)
            {
                var selectedRow = (DataRowView)CBXCPaciente.SelectedItem;
                TxtNombrePaciente.Text = selectedRow["NombreApellido"].ToString();
            }
        }


        private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.cONSULTORIORADDataSet8.Citas);
            view.RowFilter = "Estado = true";
            DGVCita.DataSource = view;
        }

        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.cONSULTORIORADDataSet8.Citas);
            view.RowFilter = "Estado = false";
            DGVCita.DataSource = view;
        }

        

        private void LimpiarCampos()
        {
            CBXCMedico.SelectedIndex = -1;
            CBXCPaciente.SelectedIndex = -1;
            DTPFechaCita.Value = DateTime.Now;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
