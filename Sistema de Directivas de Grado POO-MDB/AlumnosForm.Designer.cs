namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    partial class AlumnosForm
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
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.lblGradoYSeccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeccion.Enabled = false;
            this.cmbSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(468, 83);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(52, 29);
            this.cmbSeccion.TabIndex = 27;
            this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.CmbSeccion_SelectedIndexChanged);
            // 
            // cmbGrado
            // 
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(410, 83);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(52, 29);
            this.cmbGrado.TabIndex = 26;
            this.cmbGrado.SelectedIndexChanged += new System.EventHandler(this.CmbGrado_SelectedIndexChanged);
            // 
            // lblGradoYSeccion
            // 
            this.lblGradoYSeccion.AutoSize = true;
            this.lblGradoYSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradoYSeccion.Location = new System.Drawing.Point(173, 86);
            this.lblGradoYSeccion.Name = "lblGradoYSeccion";
            this.lblGradoYSeccion.Size = new System.Drawing.Size(231, 21);
            this.lblGradoYSeccion.TabIndex = 22;
            this.lblGradoYSeccion.Text = "Seleccionar grado y sección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(172, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Listado de alumnos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(34, 160);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(716, 240);
            this.dgvListado.TabIndex = 38;
            this.dgvListado.DoubleClick += new System.EventHandler(this.dgvListado_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(580, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 39;
            this.button1.Text = "Agregar Alumno";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Brown;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(312, 414);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(170, 45);
            this.btnRegresar.TabIndex = 41;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Image = global::Sistema_de_Directivas_de_Grado_POO_MDB.Properties.Resources.icono_alumno;
            this.pcbImagen.Location = new System.Drawing.Point(34, 25);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(106, 100);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 25;
            this.pcbImagen.TabStop = false;
            // 
            // AlumnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.lblGradoYSeccion);
            this.MaximizeBox = false;
            this.Name = "AlumnosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de alumnos";
            this.Load += new System.EventHandler(this.AlumnosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lblGradoYSeccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegresar;
    }
}