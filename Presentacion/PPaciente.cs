using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PPaciente : Form
    {
        public PPaciente()
        {
            InitializeComponent();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnCerrar.Click += BtnCerrar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            DGVPaciente.CellDoubleClick += DGVPaciente_CellDoubleClick;
            pacientesBindingSource.Filter = "Estado = true";

        }

        private void PPaciente_Load(object sender, EventArgs e)
        {
            // Cargar los datos iniciales en el DataGridView
            CargarDatosEstadoActivo();

            CBXFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();

            this.pacientesTableAdapter.Fill(this.cONSULTORIORADDataSet3.Pacientes);
            TxtId.Text = ObtenerSiguienteId().ToString();
        }

        private void DGVPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVPaciente.Rows[e.RowIndex];

                TxtId.Text = row.Cells[0].Value.ToString();
                TxtNombre.Text = row.Cells[1].Value.ToString();
                TxtApellido.Text = row.Cells[2].Value.ToString();

                // Convertir el valor de la celda a un DateTime de forma segura
                DateTime fechaIngreso;
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out fechaIngreso))
                {
                    dateTimePicker1.Value = fechaIngreso;
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

            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            bool activo = CBActivo.Checked;
            DateTime fechaIngreso = dateTimePicker1.Value;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || fechaIngreso == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = $"¿Desea guardar el paciente {nombre} {apellido}?";

            // Mostrar el cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                string query = "INSERT INTO Pacientes (Nombre, Apellidos, FechaIngreso, Estado) VALUES (@Nombre, @Apellidos, @FechaIngreso, @Estado)";
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))

                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros al comando
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellidos", apellido);
                        command.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
                        command.Parameters.AddWithValue("@Estado", activo);

                        // Ejecutar el comando de inserción
                        command.ExecuteNonQuery();
                    }
                }

                this.pacientesTableAdapter.Fill(this.cONSULTORIORADDataSet3.Pacientes);
                LimpiarCampos();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del paciente a modificar
            int idPaciente = int.Parse(TxtId.Text);

            // Obtener los nuevos valores de los campos de entrada
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            bool activo = CBActivo.Checked;
            DateTime fechaIngreso = dateTimePicker1.Value;

            // Verificar si los campos obligatorios están vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || fechaIngreso == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el mensaje de confirmación
            string mensaje = $"¿Desea modificar el paciente {nombre} {apellido}?";

            // Mostrar el cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar si el usuario confirmó la acción
            if (resultado == DialogResult.Yes)
            {
                // Crear la cadena SQL para la actualización
                string query = "UPDATE Pacientes SET Nombre = @Nombre, Apellidos = @Apellidos, FechaIngreso = @FechaIngreso, Estado = @Estado WHERE PacienteId = @PacienteId";

                // Crear la conexión a la base de datos
                 using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear el comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros al comando
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellidos", apellido);
                        command.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
                        command.Parameters.AddWithValue("@Estado", activo);
                        command.Parameters.AddWithValue("@PacienteId", idPaciente);

                        // Ejecutar el comando de actualización
                        command.ExecuteNonQuery();
                    }
                }

                // Actualizar el DataGridView con los nuevos datos
                this.pacientesTableAdapter.Fill(this.cONSULTORIORADDataSet3.Pacientes);

                TxtId.Text = ObtenerSiguienteId().ToString();

                // Limpiar los campos después de modificar
                LimpiarCampos();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVPaciente.SelectedRows.Count > 0)
            {
                // Obtener el ID del paciente seleccionado
                int idPaciente = Convert.ToInt32(DGVPaciente.SelectedRows[0].Cells[0].Value);

                // Crear el mensaje de confirmación
                string mensaje = "¿Desea eliminar el paciente seleccionado?";

                // Mostrar el cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar si el usuario confirmó la acción
                if (resultado == DialogResult.Yes)
                {
                    // Actualizar el estado del paciente a false
                    string query = "UPDATE Pacientes SET Estado = 0 WHERE PacienteId = @PacienteId";

                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PacienteId", idPaciente);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Actualizar el DataGridView con los nuevos datos
                    this.pacientesTableAdapter.Fill(this.cONSULTORIORADDataSet3.Pacientes);

                    LimpiarCampos();
                }
            }
        }
        private int ObtenerSiguienteId()
        {
            int siguienteId = 0;

            // Crear la cadena SQL para obtener el máximo ID actual
            string query = "SELECT ISNULL(MAX(PacienteId), 0) FROM Pacientes";

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

            // Incrementar el ID siguiente
            siguienteId++;

            return siguienteId;
        }


        private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.cONSULTORIORADDataSet3.Pacientes);
            view.RowFilter = "Estado = true";
            DGVPaciente.DataSource = view;
        }

        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.cONSULTORIORADDataSet3.Pacientes);
            view.RowFilter = "Estado = false";
            DGVPaciente.DataSource = view;
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


        private void LimpiarCampos()
        {
            TxtId.Text = ObtenerSiguienteId().ToString();
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            CBActivo.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
