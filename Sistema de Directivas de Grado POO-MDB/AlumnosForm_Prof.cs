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
    public partial class AlumnosForm_Prof : Form
    {
        public AlumnosForm_Prof(String id)
        {

            InitializeComponent();
            String codigo = id;
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT * FROM Secciones sec INNER JOIN Profesores pro ON sec.IdProfesor = pro.IdProfesor WHERE pro.idProfesor=@profe", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@profe", codigo);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                secName.Text = (registro["idSeccion"].ToString());
                
                
            }

            conexion.Close();
        }

        private void AlumnosForm_Prof_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT alu.Carnet, per.PrimerNombre, per.SegundoNombre, per.PrimerApellido, per.SegundoApellido FROM Alumnos alu" +
                " INNER JOIN Personas per ON alu.IdPersona = per.IdPersona" +
                " INNER JOIN Secciones sec ON alu.IdSeccion = sec.IdSeccion WHERE sec.idSeccion = @seccion", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@seccion", secName.Text);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;


            conexion.Close();
        }

        private void SecName_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String kodigo = secName.Text;
            AgregarAlumno_prof form = new AgregarAlumno_prof(kodigo);
            form.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }
    }
}