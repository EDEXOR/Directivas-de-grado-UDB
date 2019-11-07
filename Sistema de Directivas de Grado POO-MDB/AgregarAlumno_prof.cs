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
    public partial class AgregarAlumno_prof : Form
    {
        public AgregarAlumno_prof(String id)
        {
            
            InitializeComponent();
            kodigo.Text = id;
            cmbAlumno.Items.Clear();
            cmbAlumno.Enabled = true;
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT alu.IdPersona, per.IdPersona, alu.IdSeccion, sec.IdSeccion, alu.Carnet, per.PrimerNombre, per.SegundoNombre, per.PrimerApellido, per.SegundoApellido FROM Alumnos alu" +
                " INNER JOIN Personas per ON alu.IdPersona = per.IdPersona" +
                " INNER JOIN Secciones sec ON alu.IdSeccion = sec.IdSeccion WHERE sec.idSeccion = @seccion", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@seccion", id);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cmbAlumno.Items.Add(registro["Carnet"].ToString());
                
            }
            conexion.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            String alumno = "";
            String cargo = "";
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando1 = new SqlCommand("SELECT * FROM Alumnos WHERE Carnet = @carnet", conexion);
            comando1.Parameters.AddWithValue("@carnet", cmbAlumno.SelectedItem.ToString());
            SqlDataReader registro1 = comando1.ExecuteReader();
            while (registro1.Read())
            {
               alumno =registro1["idAlumno"].ToString();
            }
            conexion.Close();

            SqlConnection conexioon = Conexion.conectar();
            SqlCommand comandoo1 = new SqlCommand("SELECT idCargo FROM Cargos WHERE Cargo = @cargo", conexioon);
            comandoo1.Parameters.AddWithValue("@cargo", cmbCargo.SelectedItem.ToString());
            SqlDataReader registroo1 = comandoo1.ExecuteReader();
            while (registroo1.Read())
            {
                cargo = registroo1["idCargo"].ToString();
            }
            conexioon.Close();



            SqlConnection conexion2 = Conexion.conectar();

            SqlCommand codP = new SqlCommand("SELECT COUNT(*) FROM Alumnos_Directivas", conexion2);
            codP.Parameters.Clear();
            int CantidadP = Convert.ToInt32(codP.ExecuteScalar()) + 1;

            String codigoP = "";

            if (CantidadP < 10)
            {
                codigoP = ("D0000" + CantidadP.ToString());
            }
            else if (CantidadP >= 10 && CantidadP < 100)
            {
                codigoP = ("D000" + CantidadP.ToString());
            }
            else if (CantidadP >= 100 && CantidadP < 1000)
            {
                codigoP = ("D00" + CantidadP.ToString());
            }
            else if (CantidadP >= 1000 && CantidadP < 10000)
            {
                codigoP = ("D0" + CantidadP.ToString());
            }
            conexion2.Close();

            MessageBox.Show(cmbAlumno.SelectedItem.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


            SqlConnection conexiooon = Conexion.conectar();
            SqlCommand comandooo1 = new SqlCommand("INSERT INTO Alumnos_Directivas VALUES(@id, @idAlumno, @idCargo);", conexiooon);
            comandooo1.Parameters.AddWithValue("@id", codigoP);
            comandooo1.Parameters.AddWithValue("@idAlumno", alumno);
            comandooo1.Parameters.AddWithValue("@idCargo", cargo);
            SqlDataReader registrooo1 = comandooo1.ExecuteReader();
            while (registroo1.Read())
            {
                MessageBox.Show("Se agrego bien paloma", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexiooon.Close();
        }

        private void AgregarAlumno_prof_Load(object sender, EventArgs e)
        {
            
        }

        private void CmbAlumno_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }
    }
}
