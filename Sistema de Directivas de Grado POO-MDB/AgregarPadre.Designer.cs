namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    partial class AgregarPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPadre));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.pcbAlumno = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblPadre = new System.Windows.Forms.Label();
            this.lblGradoYSeccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(198, 347);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 45);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // cmbCargo
            // 
            this.cmbCargo.Enabled = false;
            this.cmbCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(288, 292);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(182, 25);
            this.cmbCargo.TabIndex = 29;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.Enabled = false;
            this.cmbAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(288, 244);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(182, 25);
            this.cmbAlumno.TabIndex = 28;
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Enabled = false;
            this.cmbSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(387, 195);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(52, 29);
            this.cmbSeccion.TabIndex = 27;
            // 
            // cmbGrado
            // 
            this.cmbGrado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(320, 195);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(52, 29);
            this.cmbGrado.TabIndex = 26;
            // 
            // pcbAlumno
            // 
            this.pcbAlumno.Image = ((System.Drawing.Image)(resources.GetObject("pcbAlumno.Image")));
            this.pcbAlumno.Location = new System.Drawing.Point(177, 32);
            this.pcbAlumno.Name = "pcbAlumno";
            this.pcbAlumno.Size = new System.Drawing.Size(140, 140);
            this.pcbAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAlumno.TabIndex = 25;
            this.pcbAlumno.TabStop = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(39, 291);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(155, 21);
            this.lblCargo.TabIndex = 24;
            this.lblCargo.Text = "Seleccionar cargo:";
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadre.Location = new System.Drawing.Point(39, 243);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(156, 21);
            this.lblPadre.TabIndex = 23;
            this.lblPadre.Text = "Seleccionar padre:";
            // 
            // lblGradoYSeccion
            // 
            this.lblGradoYSeccion.AutoSize = true;
            this.lblGradoYSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradoYSeccion.Location = new System.Drawing.Point(39, 198);
            this.lblGradoYSeccion.Name = "lblGradoYSeccion";
            this.lblGradoYSeccion.Size = new System.Drawing.Size(231, 21);
            this.lblGradoYSeccion.TabIndex = 22;
            this.lblGradoYSeccion.Text = "Seleccionar grado y sección:";
            // 
            // AgregarPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 424);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.pcbAlumno);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.lblGradoYSeccion);
            this.MaximizeBox = false;
            this.Name = "AgregarPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar cargo a padre";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.PictureBox pcbAlumno;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.Label lblGradoYSeccion;
    }
}