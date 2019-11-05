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
    public partial class AlumnosForm : Form
    {
        public AlumnosForm()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void AlumnosForm_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT Grado FROM Grados", conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                cmbGrado.Items.Add(registro["Grado"].ToString());
            }
            conexion.Close();
        }

        private void CmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeccion.Items.Clear();
            cmbSeccion.Enabled = true;
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT Seccion FROM Secciones sec INNER JOIN Grados gra ON sec.IdGrado = gra.IdGrado WHERE gra.Grado=@grado", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@grado", Int32.Parse(cmbGrado.Text));
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cmbSeccion.Items.Add(registro["Seccion"].ToString());
            }
            conexion.Close();
        }

        private void CmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {


            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT  alu.Carnet, per.PrimerNombre, per.SegundoNombre, per.PrimerApellido, per.SegundoApellido FROM Alumnos alu" +
                " INNER JOIN Personas per ON alu.IdPersona = per.IdPersona" +
                " INNER JOIN Secciones sec ON alu.IdSeccion = sec.IdSeccion WHERE sec.Seccion = @seccion", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@seccion", cmbSeccion.Text);
            SqlDataAdapter da = new SqlDataAdapter(comando);
		DataTable dt = new DataTable();
		da.Fill(dt);
          
                dataGridView1.DataSource = dt;
                
            
            conexion.Close();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RegistrarAlumno form = new RegistrarAlumno();
            form.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            menu form = new menu();
            form.Show();
            this.Hide();
        }
    }
}
