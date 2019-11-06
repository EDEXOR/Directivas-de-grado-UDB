using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    public partial class menu_profesores : Form
    {
        String kodigo = "";
        public menu_profesores(String id)
        {
            InitializeComponent();
            String codigo = id;

            kodigo = codigo;

            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT * FROM Personas per INNER JOIN Profesores pro ON per.IdPersona = pro.IdPersona WHERE pro.idProfesor=@profe", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@profe", codigo);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                String nombre = (registro["PrimerNombre"].ToString()) + " " + (registro["SegundoNombre"].ToString()) + " " + (registro["PrimerApellido"].ToString());
                nameTeacher.Text = nombre;

            }

            conexion.Close();

        }

        private void Menu_profesores_Load(object sender, EventArgs e)
        {

        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosForm_Prof form = new AlumnosForm_Prof(kodigo);
            form.Show();
            this.Hide();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}