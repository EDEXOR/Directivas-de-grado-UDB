namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    partial class AgregarAlumno_prof
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAlumno_prof));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.pcbAlumno = new System.Windows.Forms.PictureBox();
            this.kodigo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(190, 358);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 45);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Enabled = false;
            this.cmbCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(283, 283);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(182, 25);
            this.cmbCargo.TabIndex = 29;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumno.Enabled = false;
            this.cmbAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(283, 235);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(182, 25);
            this.cmbAlumno.TabIndex = 28;
            this.cmbAlumno.SelectedIndexChanged += new System.EventHandler(this.CmbAlumno_SelectedIndexChanged);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(34, 282);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(155, 21);
            this.lblCargo.TabIndex = 24;
            this.lblCargo.Text = "Seleccionar cargo:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(34, 234);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(167, 21);
            this.lblAlumno.TabIndex = 23;
            this.lblAlumno.Text = "Seleccionar alumno:";
            // 
            // pcbAlumno
            // 
            this.pcbAlumno.Image = ((System.Drawing.Image)(resources.GetObject("pcbAlumno.Image")));
            this.pcbAlumno.Location = new System.Drawing.Point(169, 43);
            this.pcbAlumno.Name = "pcbAlumno";
            this.pcbAlumno.Size = new System.Drawing.Size(140, 140);
            this.pcbAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAlumno.TabIndex = 25;
            this.pcbAlumno.TabStop = false;
            // 
            // kodigo
            // 
            this.kodigo.AutoSize = true;
            this.kodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodigo.Location = new System.Drawing.Point(34, 43);
            this.kodigo.Name = "kodigo";
            this.kodigo.Size = new System.Drawing.Size(46, 21);
            this.kodigo.TabIndex = 31;
            this.kodigo.Text = "UwU";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Brown;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(367, 358);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(98, 45);
            this.btnRegresar.TabIndex = 89;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // AgregarAlumno_prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 446);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.kodigo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.pcbAlumno);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblAlumno);
            this.MaximizeBox = false;
            this.Name = "AgregarAlumno_prof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar cargo a alumno";
            this.Load += new System.EventHandler(this.AgregarAlumno_prof_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.PictureBox pcbAlumno;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label kodigo;
        private System.Windows.Forms.Button btnRegresar;
    }
}