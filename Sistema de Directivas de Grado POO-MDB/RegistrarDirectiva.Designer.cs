namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    partial class RegistrarDirectiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarDirectiva));
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnPadres = new System.Windows.Forms.Button();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblPadres = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.BackgroundImage")));
            this.btnAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Location = new System.Drawing.Point(53, 33);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(111, 103);
            this.btnAlumnos.TabIndex = 43;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnPadres
            // 
            this.btnPadres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPadres.BackgroundImage")));
            this.btnPadres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPadres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPadres.Location = new System.Drawing.Point(217, 33);
            this.btnPadres.Name = "btnPadres";
            this.btnPadres.Size = new System.Drawing.Size(111, 103);
            this.btnPadres.TabIndex = 44;
            this.btnPadres.UseVisualStyleBackColor = true;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlumnos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlumnos.Location = new System.Drawing.Point(49, 152);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(119, 38);
            this.lblAlumnos.TabIndex = 45;
            this.lblAlumnos.Text = "Asignar cargo\r\na alumno";
            this.lblAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPadres
            // 
            this.lblPadres.AutoSize = true;
            this.lblPadres.BackColor = System.Drawing.Color.Transparent;
            this.lblPadres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPadres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPadres.Location = new System.Drawing.Point(194, 152);
            this.lblPadres.Name = "lblPadres";
            this.lblPadres.Size = new System.Drawing.Size(155, 38);
            this.lblPadres.TabIndex = 46;
            this.lblPadres.Text = "Asignar cargo\r\na padre de familia\r\n";
            this.lblPadres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Brown;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(108, 207);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(170, 45);
            this.btnRegresar.TabIndex = 57;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // RegistrarDirectiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(380, 273);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblPadres);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.btnPadres);
            this.Controls.Add(this.btnAlumnos);
            this.MaximizeBox = false;
            this.Name = "RegistrarDirectiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar directiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnPadres;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblPadres;
        private System.Windows.Forms.Button btnRegresar;
    }
}