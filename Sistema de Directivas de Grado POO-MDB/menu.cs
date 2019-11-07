using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Alumnos_Click(object sender, EventArgs e)
        {
            AlumnosForm form = new AlumnosForm();
            form.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            ProfesoresForm form = new ProfesoresForm();
            form.Show();
            this.Hide();
        }

        private void btnPadres_Click(object sender, EventArgs e)
        {
            PadresForm form = new PadresForm();
            form.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosForm form = new UsuariosForm();
            form.Show();
            this.Hide();
        }

        private void btnDirectivas_Click(object sender, EventArgs e)
        {
            RegistrarDirectiva form = new RegistrarDirectiva();
            form.Show();
            this.Hide();
        }
    }
}
