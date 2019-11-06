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
    public partial class RegistrarDirectiva : Form
    {
        public RegistrarDirectiva()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            form.Show();
            this.Hide();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AgregarAlumno form = new AgregarAlumno();
            form.Show();
            this.Hide();
        }
    }
}
