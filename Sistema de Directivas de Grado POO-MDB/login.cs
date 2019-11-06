using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        static bool flag = false;
        private void Login_Load(object sender, EventArgs e)
        {
            Inicio form1 = new Inicio();
            form1.Hide();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            Creditos form_credi = new Creditos();
            form_credi.Show();
            this.Hide();
            Validaciones val = new Validaciones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarPass(e, txtPassword);
        }


        private void TxtCorreo_Validated(object sender, EventArgs e)
        {
            if (Validaciones.ValidarEmail(txtCorreo.Text))
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                SqlConnection conexion = Conexion.conectar();
                SqlCommand cm = new SqlCommand("SELECT * FROM Usuarios WHERE Correo=@correo AND Clave=@clave", conexion);
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cm.Parameters.AddWithValue("@clave", txtPassword.Text);
                SqlDataReader reader = cm.ExecuteReader();



                if (reader.Read())
                {
                    String tipo = reader["TipoUsuario"].ToString();
                    String id = reader["idProfesor"].ToString();

                    if (tipo == "1")
                    {
                        frmMenu form = new frmMenu();
                        form.Show();
                        this.Hide();
                    }
                    else if (tipo == "2")
                    {
                        menu_profesores form = new menu_profesores(id);
                        form.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexion.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos solicitados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
