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
    public partial class AgregarAlumno : Form
    {
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void AgregarAlumno_Load(object sender, EventArgs e)
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

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAlumno.Items.Clear();
            cmbAlumno.Enabled = true;
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT alu.IdPersona, per.IdPersona, alu.IdSeccion, sec.IdSeccion, alu.Carnet, per.PrimerNombre, per.SegundoNombre, per.PrimerApellido, per.SegundoApellido FROM Alumnos alu" +
                " INNER JOIN Personas per ON alu.IdPersona = per.IdPersona" +
                " INNER JOIN Secciones sec ON alu.IdSeccion = sec.IdSeccion WHERE sec.Seccion = @seccion", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@seccion", cmbSeccion.Text);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cmbAlumno.Items.Add(registro["Carnet"].ToString());
            }
            conexion.Close();
        }

        private void cmbAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCargo.Items.Clear();
            cmbCargo.Enabled = true;
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando1 = new SqlCommand("SELECT Cargo FROM Cargos", conexion);
            SqlDataReader registro1 = comando1.ExecuteReader();
            while (registro1.Read())
            {
                cmbCargo.Items.Add(registro1["Cargo"].ToString());
            }
            conexion.Close();
        }
    }
}
