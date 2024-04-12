namespace Presentacion
{
    partial class PMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMedico));
            this.DGVMedico = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cONSULTORIORADDataSet = new Presentacion.CONSULTORIORADDataSet();
            this.cONSULTORIORADDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIORADDataSet1 = new Presentacion.CONSULTORIORADDataSet1();
            this.cONSULTORIORADDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.CBXFiltro = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.medicoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIORADDataSet2 = new Presentacion.CONSULTORIORADDataSet2();
            this.medicosTableAdapter = new Presentacion.CONSULTORIORADDataSet2TableAdapters.MedicosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMedico
            // 
            this.DGVMedico.AllowUserToDeleteRows = false;
            this.DGVMedico.AutoGenerateColumns = false;
            this.DGVMedico.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.DGVMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicoIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.DGVMedico.DataSource = this.medicosBindingSource;
            this.DGVMedico.Location = new System.Drawing.Point(9, 215);
            this.DGVMedico.Name = "DGVMedico";
            this.DGVMedico.ReadOnly = true;
            this.DGVMedico.RowHeadersWidth = 62;
            this.DGVMedico.RowTemplate.Height = 28;
            this.DGVMedico.Size = new System.Drawing.Size(1097, 259);
            this.DGVMedico.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(705, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.BackColor = System.Drawing.Color.Transparent;
            this.CBActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBActivo.ForeColor = System.Drawing.Color.White;
            this.CBActivo.Location = new System.Drawing.Point(160, 168);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(136, 41);
            this.CBActivo.TabIndex = 19;
            this.CBActivo.Text = "Activo";
            this.CBActivo.UseVisualStyleBackColor = false;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(186, 123);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(287, 26);
            this.TxtApellido.TabIndex = 18;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(186, 76);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(287, 26);
            this.TxtNombre.TabIndex = 17;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(63, 25);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(131, 26);
            this.TxtId.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(2, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(728, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha de ingreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(2, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellidos:";
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.BackColor = System.Drawing.Color.Transparent;
            this.Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombres.ForeColor = System.Drawing.Color.Transparent;
            this.Nombres.Location = new System.Drawing.Point(2, 65);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(165, 37);
            this.Nombres.TabIndex = 12;
            this.Nombres.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id:";
            // 
            // cONSULTORIORADDataSet
            // 
            this.cONSULTORIORADDataSet.DataSetName = "CONSULTORIORADDataSet";
            this.cONSULTORIORADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONSULTORIORADDataSetBindingSource
            // 
            this.cONSULTORIORADDataSetBindingSource.DataSource = this.cONSULTORIORADDataSet;
            this.cONSULTORIORADDataSetBindingSource.Position = 0;
            // 
            // cONSULTORIORADDataSet1
            // 
            this.cONSULTORIORADDataSet1.DataSetName = "CONSULTORIORADDataSet1";
            this.cONSULTORIORADDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONSULTORIORADDataSet1BindingSource
            // 
            this.cONSULTORIORADDataSet1BindingSource.DataSource = this.cONSULTORIORADDataSet1;
            this.cONSULTORIORADDataSet1BindingSource.Position = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(687, 131);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 60);
            this.BtnGuardar.TabIndex = 22;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(837, 131);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(127, 60);
            this.BtnModificar.TabIndex = 23;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(979, 131);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(127, 60);
            this.BtnEliminar.TabIndex = 24;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(1080, -2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(39, 26);
            this.BtnCerrar.TabIndex = 25;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // CBXFiltro
            // 
            this.CBXFiltro.FormattingEnabled = true;
            this.CBXFiltro.Location = new System.Drawing.Point(464, 181);
            this.CBXFiltro.Name = "CBXFiltro";
            this.CBXFiltro.Size = new System.Drawing.Size(177, 28);
            this.CBXFiltro.TabIndex = 26;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(341, 172);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 37);
            this.label.TabIndex = 27;
            this.label.Text = "Filtrar:";
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
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidosDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaIngresoDataGridViewTextBoxColumn.Width = 150;
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
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.cONSULTORIORADDataSet2;
            // 
            // cONSULTORIORADDataSet2
            // 
            this.cONSULTORIORADDataSet2.DataSetName = "CONSULTORIORADDataSet2";
            this.cONSULTORIORADDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // PMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 486);
            this.Controls.Add(this.label);
            this.Controls.Add(this.CBXFiltro);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DGVMedico);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CBActivo);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMedico";
            this.Load += new System.EventHandler(this.PMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIORADDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMedico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cONSULTORIORADDataSet1BindingSource;
        private CONSULTORIORADDataSet1 cONSULTORIORADDataSet1;
        private CONSULTORIORADDataSet cONSULTORIORADDataSet;
        private System.Windows.Forms.BindingSource cONSULTORIORADDataSetBindingSource;
        private CONSULTORIORADDataSet2 cONSULTORIORADDataSet2;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private CONSULTORIORADDataSet2TableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ComboBox CBXFiltro;
        private System.Windows.Forms.Label label;
    }
}