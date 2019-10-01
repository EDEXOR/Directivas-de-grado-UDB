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

        private void login_Load(object sender, EventArgs e)
        {
            Inicio form1 = new Inicio();
            form1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (val.ValidarEmail(txtCorreo.Text))
            {
                //si es correcto no debe hacer nada
            }
            else
            {
                /*sino es correcto que envíe este mensaje y se posicione para
verificar recuerde que se activará la validación al dar click en otro textbox o
simplemente dejar o salir de esa casilla de email*/

                MessageBox.Show("Dirección de correo no válida");
                txtCorreo.SelectAll(); //selecciona todo lo de la casilla
                txtCorreo.Focus(); //se posiciona ahí de nuevo
            }
           
        }
    }
}
