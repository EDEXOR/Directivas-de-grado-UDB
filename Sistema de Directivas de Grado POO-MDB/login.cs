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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        Validaciones val = new Validaciones();
static bool flag = false;
        private void login_Load(object sender, EventArgs e)
        {
            Inicio form1 = new Inicio();
            form1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Creditos form_credi = new Creditos();
            form_credi.Show();
            this.Hide();
            Validaciones val = new Validaciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarPass(e, txtPassword);
        }


        private void TxtCorreo_Validated(object sender, EventArgs e)
        {
            if (val.ValidarEmail(txtCorreo.Text))
            {
                flag = true;
                errorProvider1.Clear();
            }
            else
            {
                flag = false;
                errorProvider1.SetError(txtCorreo, "Dirección no válida");
                txtCorreo.SelectAll(); //selecciona todo lo de la casilla
                txtCorreo.Focus(); //se posiciona ahí de nuevo
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Agregar acá login");
            }
            else
            {
                MessageBox.Show("Error validando...");
            }
        }
    }
}
