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
    public partial class ModificarAlumno : Form
    {
        public string carnet = "";
        public ModificarAlumno()
        {
            InitializeComponent();
        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {

            //Cargar combobox
            SqlConnection conexion1 = Conexion.conectar();
            SqlCommand comando1 = new SqlCommand("SELECT pa.IdPadre, PrimerNombre, SegundoNombre, TercerNombre, PrimerApellido, SegundoApellido, Telefono, Email FROM Padres pa" +
                " INNER JOIN Personas per ON per.IdPersona = pa.IdPersona", conexion1);
            SqlDataReader registro1 = comando1.ExecuteReader();

            while (registro1.Read())
            {
                cmbPadres.ValueMember = registro1["IdPadre"].ToString();
                cmbPadres.Items.Add(registro1["PrimerNombre"].ToString() + " " + registro1["SegundoNombre"].ToString() + " " + registro1["PrimerApellido"] + " " + registro1["SegundoApellido"]);
            }
            conexion1.Close();
            cmbPadres.Enabled = true;

            SqlConnection conexion2 = Conexion.conectar();
            SqlCommand comando2 = new SqlCommand("SELECT IdGrado, Grado FROM Grados", conexion2);
            SqlDataReader registro = comando2.ExecuteReader();

            while (registro.Read())
            {
                cbGrado.ValueMember = registro["IdGrado"].ToString();
                cbGrado.Items.Add(registro["Grado"].ToString());
            }
            conexion2.Close();
            cbGrado.Enabled = true;

            // ****************************************************************

            string codigo = carnet;
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT gra.IdGrado, alu.IdPadre, alu.Carnet, per.PrimerNombre, per.SegundoNombre, per.TercerNombre," +
                "per.PrimerApellido, per.SegundoApellido, per.Telefono, per.Email FROM Alumnos alu " +
                "INNER JOIN Personas per ON alu.IdPersona = per.IdPersona " +
                "INNER JOIN Secciones sec ON alu.IdSeccion = sec.IdSeccion " +
                "INNER JOIN Grados gra on sec.IdGrado = gra.IdGrado " +
                "INNER JOIN Padres pa ON alu.IdPadre = pa.IdPadre WHERE alu.Carnet = @carnet", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@carnet", codigo);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                txtPrimerNombre.Text = Convert.ToString(reader["PrimerNombre"]);
                txtSegundoNombre.Text = Convert.ToString(reader["SegundoNombre"]);
                txtTercerNombre.Text = Convert.ToString(reader["TercerNombre"]);
                txtPrimerApellido.Text = Convert.ToString(reader["PrimerApellido"]);
                txtSegundoApellido.Text = Convert.ToString(reader["SegundoApellido"]);
                txtCarnet.Text = Convert.ToString(reader["Carnet"]);
                txtTelefono.Text = Convert.ToString(reader["Telefono"]);
                txtCorreo.Text = Convert.ToString(reader["Email"]);
                cmbPadres.SelectedValue = Convert.ToString(reader["IdPadre"]);
                cbGrado.SelectedValue = Convert.ToString(reader["IdGrado"]);
            }
            conexion.Close();
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexion3 = Conexion.conectar();
            SqlCommand comando3 = new SqlCommand("SELECT IdSeccion, Seccion FROM Secciones sec INNER JOIN Grados gra ON sec.IdGrado = gra.IdGrado WHERE gra.Grado=@grado", conexion3);
            comando3.Parameters.Clear();
            comando3.Parameters.AddWithValue("@grado", Int32.Parse(cbGrado.Text));
            SqlDataReader registro3 = comando3.ExecuteReader();
            while (registro3.Read())
            {
                cbSeccion.ValueMember = registro3["IdSeccion"].ToString();
                cbSeccion.Items.Add(registro3["Seccion"].ToString());
            }
            conexion3.Close();
            cbSeccion.Enabled = true;
        }
    }
}
