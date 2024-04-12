using Datos.Base_de_datos;
using Datos.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PMedico : Form
    {
        public PMedico()
        {
            InitializeComponent();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnCerrar.Click += BtnCerrar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            DGVMedico.CellDoubleClick += DGVMedico_CellDoubleClick;
            medicosBindingSource.Filter = "Estado = true";

            CBXFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();
            
        }

        private void PMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cONSULTORIORADDataSet2.Medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.cONSULTORIORADDataSet2.Medicos);

            // Mostrar el siguiente ID en el TextBox TxtId
            TxtId.Text = ObtenerSiguienteId().ToString();
        }

        private void DGVMedico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVMedico.Rows[e.RowIndex];

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
            // Obtener los valores de los campos de entrada
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
            string mensaje = $"¿Desea guardar el médico {nombre} {apellido}?";

            // Mostrar el cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar si el usuario confirmó la acción
            if (resultado == DialogResult.Yes)
            {
                // Crear la cadena SQL para la inserción
                string query = "INSERT INTO Medicos (Nombre, Apellidos, FechaIngreso, Estado) VALUES (@Nombre, @Apellidos, @FechaIngreso, @Estado)";

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
                        command.ExecuteNonQuery();
                    }
                }

                // Actualizar el DataGridView con los nuevos datos
                this.medicosTableAdapter.Fill(this.cONSULTORIORADDataSet2.Medicos);

                // Mostrar el siguiente ID actualizado en el TextBox TxtId
                TxtId.Text = ObtenerSiguienteId().ToString();

                // Limpiar los campos después de guardar
                LimpiarCampos();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del médico a modificar
            int idMedico = int.Parse(TxtId.Text);

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
            string mensaje = $"¿Desea modificar el médico {nombre} {apellido}?";

            // Mostrar el cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar si el usuario confirmó la acción
            if (resultado == DialogResult.Yes)
            {
                // Crear la cadena SQL para la actualización
                string query = "UPDATE Medicos SET Nombre = @Nombre, Apellidos = @Apellidos, FechaIngreso = @FechaIngreso, Estado = @Estado WHERE MedicoId = @MedicoId";

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
                        command.Parameters.AddWithValue("@MedicoId", idMedico);

                        // Ejecutar el comando de actualización
                        command.ExecuteNonQuery();
                    }
                }

                // Actualizar el DataGridView con los nuevos datos
                this.medicosTableAdapter.Fill(this.cONSULTORIORADDataSet2.Medicos);

                // Limpiar los campos después de modificar
                LimpiarCampos();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVMedico.SelectedRows.Count > 0)
            {
                // Obtener el ID del médico seleccionado
                int idMedico = Convert.ToInt32(DGVMedico.SelectedRows[0].Cells[0].Value);

                // Crear el mensaje de confirmación
                string mensaje = "¿Desea eliminar el médico seleccionado?";

                // Mostrar el cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar si el usuario confirmó la acción
                if (resultado == DialogResult.Yes)
                {
                    // Actualizar el estado del médico a false
                    string query = "UPDATE Medicos SET Estado = 0 WHERE MedicoId = @MedicoId";

                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True"))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MedicoId", idMedico);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Actualizar el DataGridView con los nuevos datos
                    this.medicosTableAdapter.Fill(this.cONSULTORIORADDataSet2.Medicos);

                    LimpiarCampos();
                }
            }
        }


        private int ObtenerSiguienteId()
        {
            int siguienteId = 0;

            // Crear la cadena SQL para obtener el máximo ID actual
            string query = "SELECT ISNULL(MAX(MedicoId), 0) FROM Medicos";

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
            DataView view = new DataView(this.cONSULTORIORADDataSet2.Medicos);
            view.RowFilter = "Estado = true";
            DGVMedico.DataSource = view;
        }

        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.cONSULTORIORADDataSet2.Medicos);
            view.RowFilter = "Estado = false";
            DGVMedico.DataSource = view;
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
