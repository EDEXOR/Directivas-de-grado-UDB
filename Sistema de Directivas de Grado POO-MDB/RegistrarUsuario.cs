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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            UsuariosForm form = new UsuariosForm();
            form.Show();
            this.Hide();
        }
    }
}
