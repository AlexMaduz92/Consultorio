namespace Presentacion
{
    partial class PCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.CBXFiltro = new System.Windows.Forms.ComboBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DGVCita = new System.Windows.Forms.DataGridView();
            this.DTPFechaCita = new System.Windows.Forms.DateTimePicker();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.TxtNombrePaciente = new System.Windows.Forms.TextBox();
            this.TxtNombreMedico = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBXCMedico = new System.Windows.Forms.ComboBox();
            this.CBXCPaciente = new System.Windows.Forms.ComboBox();
            this.cONSULTORIORADDataSet8 = new Presentacion.CONSULTORIORADDataSet8();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasTableAdapter = new Presentacion.CONSULTORIORADDataSet8TableAdapters.CitasTableAdapter();
            this.citaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(369, 308);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 37);
            this.label.TabIndex = 61;
            this.label.Text = "Filtrar:";
            // 
            // CBXFiltro
            // 
            this.CBXFiltro.FormattingEnabled = true;
            this.CBXFiltro.Location = new System.Drawing.Point(492, 317);
            this.CBXFiltro.Name = "CBXFiltro";
            this.CBXFiltro.Size = new System.Drawing.Size(177, 28);
            this.CBXFiltro.TabIndex = 60;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(1210, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(39, 26);
            this.BtnCerrar.TabIndex = 59;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(1110, 281);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(127, 60);
            this.BtnEliminar.TabIndex = 58;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(968, 281);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(127, 60);
            this.BtnModificar.TabIndex = 57;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(818, 281);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 60);
            this.BtnGuardar.TabIndex = 56;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // DGVCita
            // 
            this.DGVCita.AllowUserToDeleteRows = false;
            this.DGVCita.AutoGenerateColumns = false;
            this.DGVCita.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.DGVCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citaIdDataGridViewTextBoxColumn,
            this.medicoIdDataGridViewTextBoxColumn,
            this.pacienteIdDataGridViewTextBoxColumn,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.DGVCita.DataSource = this.citasBindingSource;
            this.DGVCita.Location = new System.Drawing.Point(12, 375);
            this.DGVCita.Name = "DGVCita";
            this.DGVCita.ReadOnly = true;
            this.DGVCita.RowHeadersWidth = 62;
            this.DGVCita.RowTemplate.Height = 28;
            this.DGVCita.Size = new System.Drawing.Size(1225, 289);
            this.DGVCita.TabIndex = 55;
            // 
            // DTPFechaCita
            // 
            this.DTPFechaCita.Location = new System.Drawing.Point(844, 77);
            this.DTPFechaCita.Name = "DTPFechaCita";
            this.DTPFechaCita.Size = new System.Drawing.Size(344, 26);
            this.DTPFechaCita.TabIndex = 54;
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.BackColor = System.Drawing.Color.Transparent;
            this.CBActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBActivo.ForeColor = System.Drawing.Color.White;
            this.CBActivo.Location = new System.Drawing.Point(188, 304);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(136, 41);
            this.CBActivo.TabIndex = 53;
            this.CBActivo.Text = "Activo";
            this.CBActivo.UseVisualStyleBackColor = false;
            // 
            // TxtNombrePaciente
            // 
            this.TxtNombrePaciente.Enabled = false;
            this.TxtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombrePaciente.Location = new System.Drawing.Point(334, 253);
            this.TxtNombrePaciente.Name = "TxtNombrePaciente";
            this.TxtNombrePaciente.Size = new System.Drawing.Size(401, 28);
            this.TxtNombrePaciente.TabIndex = 52;
            // 
            // TxtNombreMedico
            // 
            this.TxtNombreMedico.Enabled = false;
            this.TxtNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreMedico.Location = new System.Drawing.Point(334, 134);
            this.TxtNombreMedico.Name = "TxtNombreMedico";
            this.TxtNombreMedico.Size = new System.Drawing.Size(401, 28);
            this.TxtNombreMedico.TabIndex = 51;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(87, 29);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(131, 26);
            this.TxtId.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 37);
            this.label4.TabIndex = 49;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(867, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 37);
            this.label3.TabIndex = 48;
            this.label3.Text = "Fecha de la cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 37);
            this.label2.TabIndex = 47;
            this.label2.Text = "Medico asignado:";
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.BackColor = System.Drawing.Color.Transparent;
            this.Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombres.ForeColor = System.Drawing.Color.Transparent;
            this.Nombres.Location = new System.Drawing.Point(26, 69);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(254, 37);
            this.Nombres.TabIndex = 46;
            this.Nombres.Text = "Codigo medico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 37);
            this.label1.TabIndex = 45;
            this.label1.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(26, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 37);
            this.label5.TabIndex = 62;
            this.label5.Text = "Codigo paciente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(26, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 37);
            this.label6.TabIndex = 63;
            this.label6.Text = "Paciente a recibir:";
            // 
            // CBXCMedico
            // 
            this.CBXCMedico.FormattingEnabled = true;
            this.CBXCMedico.Location = new System.Drawing.Point(334, 79);
            this.CBXCMedico.Name = "CBXCMedico";
            this.CBXCMedico.Size = new System.Drawing.Size(401, 28);
            this.CBXCMedico.TabIndex = 64;
            // 
            // CBXCPaciente
            // 
            this.CBXCPaciente.FormattingEnabled = true;
            this.CBXCPaciente.Location = new System.Drawing.Point(334, 191);
            this.CBXCPaciente.Name = "CBXCPaciente";
            this.CBXCPaciente.Size = new System.Drawing.Size(401, 28);
            this.CBXCPaciente.TabIndex = 65;
            // 
            // cONSULTORIORADDataSet8
            // 
            this.cONSULTORIORADDataSet8.DataSetName = "CONSULTORIORADDataSet8";
            this.cONSULTORIORADDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.cONSULTORIORADDataSet8;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // citaIdDataGridViewTextBoxColumn
            // 
            this.citaIdDataGridViewTextBoxColumn.DataPropertyName = "CitaId";
            this.citaIdDataGridViewTextBoxColumn.HeaderText = "CitaId";
            this.citaIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.citaIdDataGridViewTextBoxColumn.Name = "citaIdDataGridViewTextBoxColumn";
            this.citaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.citaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // medicoIdDataGridViewTextBoxColumn
            // 
            this.medicoIdDataGridViewTextBoxColumn.DataPropertyName = "MedicoId";
            this.medicoIdDataGridViewTextBoxColumn.HeaderText = "MedicoId";
            this.medicoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.medicoIdDataGridViewTextBoxColumn.Name = "medicoIdDataGridViewTextBoxColumn";
            this.medicoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pacienteIdDataGridViewTextBoxColumn
            // 
            this.pacienteIdDataGridViewTextBoxColumn.DataPropertyName = "PacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.HeaderText = "PacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pacienteIdDataGridViewTextBoxColumn.Name = "pacienteIdDataGridViewTextBoxColumn";
            this.pacienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacienteIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            this.fechaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCitaDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadoDataGridViewCheckBoxColumn.Width = 150;
            // 
            // PCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1245, 697);
            this.Controls.Add(this.CBXCPaciente);
            this.Controls.Add(this.CBXCMedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.CBXFiltro);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DGVCita);
            this.Controls.Add(this.DTPFechaCita);
            this.Controls.Add(this.CBActivo);
            this.Controls.Add(this.TxtNombrePaciente);
            this.Controls.Add(this.TxtNombreMedico);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCita";
            this.Load += new System.EventHandler(this.PCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox CBXFiltro;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DGVCita;
        private System.Windows.Forms.DateTimePicker DTPFechaCita;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.TextBox TxtNombrePaciente;
        private System.Windows.Forms.TextBox TxtNombreMedico;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBXCMedico;
        private System.Windows.Forms.ComboBox CBXCPaciente;
        private CONSULTORIORADDataSet8 cONSULTORIORADDataSet8;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private CONSULTORIORADDataSet8TableAdapters.CitasTableAdapter citasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn citaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
    }
}