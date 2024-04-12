namespace Presentacion
{
    partial class PMENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMENU));
            this.BtnMedicos = new System.Windows.Forms.Button();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.BtnCitas = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // BtnMedicos
            // 
            this.BtnMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedicos.Location = new System.Drawing.Point(206, 23);
            this.BtnMedicos.Name = "BtnMedicos";
            this.BtnMedicos.Size = new System.Drawing.Size(304, 66);
            this.BtnMedicos.TabIndex = 0;
            this.BtnMedicos.Text = "Medicos";
            this.BtnMedicos.UseVisualStyleBackColor = true;
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPacientes.Location = new System.Drawing.Point(206, 153);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Size = new System.Drawing.Size(304, 66);
            this.BtnPacientes.TabIndex = 1;
            this.BtnPacientes.Text = "Pacientes";
            this.BtnPacientes.UseVisualStyleBackColor = true;
            // 
            // BtnCitas
            // 
            this.BtnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCitas.Location = new System.Drawing.Point(206, 278);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Size = new System.Drawing.Size(304, 66);
            this.BtnCitas.TabIndex = 2;
            this.BtnCitas.Text = "Citas";
            this.BtnCitas.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(206, 383);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(304, 66);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCitas);
            this.Controls.Add(this.BtnPacientes);
            this.Controls.Add(this.BtnMedicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PMENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE CITAS MEDICAS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMedicos;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Button BtnCitas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ImageList imageList1;
    }
}