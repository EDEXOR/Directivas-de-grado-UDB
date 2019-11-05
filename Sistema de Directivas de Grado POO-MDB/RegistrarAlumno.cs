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
    public partial class RegistrarAlumno : Form
    {
        public RegistrarAlumno()
        {
            InitializeComponent();
        }

        private void pcbAlumno_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexion.conectar();

            SqlCommand codP = new SqlCommand("SELECT * FROM Personas", conexion);
            codP.Parameters.Clear();
            SqlDataReader readerCodP = codP.ExecuteReader();

            int CantidadP = readerCodP.FieldCount + 2;
            String codigoP = "Nel";

            if (CantidadP <= 10)
            {
                codigoP = ("P000" + CantidadP.ToString());
            }
            else if (CantidadP >= 10 && CantidadP <= 100)
            {
                codigoP = ("P000" + CantidadP.ToString());
            }
            else if (CantidadP >= 100 && CantidadP <= 1000)
            {
                codigoP = ("P00" + CantidadP.ToString());
            }
            conexion.Close();

            SqlConnection conexioon = Conexion.conectar();

            SqlCommand codA = new SqlCommand("SELECT * FROM Alumnos", conexioon);
            codA.Parameters.Clear();
            SqlDataReader readerCodA = codA.ExecuteReader();

            int CantidadA = readerCodA.FieldCount +2;
            String codigoA = "Nel";

            if (CantidadA <= 10)
            {
                codigoA = ("A000" + CantidadA.ToString());
            }
            else if (CantidadA >= 10 && CantidadA <= 100)
            {
                codigoA = ("A000" + CantidadA.ToString());
            }
            else if (CantidadA >= 100 && CantidadA <= 1000)
            {
                codigoA = ("A00" + CantidadA.ToString());
            }
            conexioon.Close();


            SqlConnection conexiooon = Conexion.conectar();
            SqlCommand cm = new SqlCommand("INSERT INTO Personas VALUES(@codigoP, @PrimerNombre, @SegundoNombre, @TercerNombre, @PrimerApellido, @SegundoApellido, @tel, @email)", conexiooon);
            cm.Parameters.Clear();
            
            cm.Parameters.AddWithValue("@codigoP", codigoP);
            cm.Parameters.AddWithValue("@PrimerNombre", txtPrimerNombre.Text);
            cm.Parameters.AddWithValue("@SegundoNombre", txtSegundoNombre.Text);
            cm.Parameters.AddWithValue("@TercerNombre", txtTercerNombre.Text);
            cm.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
            cm.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
            cm.Parameters.AddWithValue("@tel", txtTelefono.Text);
            cm.Parameters.AddWithValue("@email", txtCorreo.Text);
            SqlDataReader dr = cm.ExecuteReader();
            conexiooon.Close();

            SqlConnection conexioooon = Conexion.conectar();
            SqlCommand com = new SqlCommand("INSERT INTO Alumnos VALUES(@codigoA, 'PA0001', @codigoP, @Grado, @carnet)", conexioooon);
            com.Parameters.Clear();

            com.Parameters.AddWithValue("@codigoA", codigoA);
            com.Parameters.AddWithValue("@codigoP", codigoP);
            com.Parameters.AddWithValue("@Grado", cbSeccion.Text);
            com.Parameters.AddWithValue("@carnet", txtCarnet.Text);
            SqlDataReader drr = com.ExecuteReader();
            conexioooon.Close();




            MessageBox.Show("Se agrego bien paloma", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
            
                
            
            
                
            
            
        }

        private void CmbEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSeccion.Items.Clear();
            cbSeccion.Enabled = true;
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT IdSeccion, Seccion FROM Secciones sec INNER JOIN Grados gra ON sec.IdGrado = gra.IdGrado WHERE gra.Grado=@grado", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@grado", Int32.Parse(cbGrado.Text));
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbSeccion.Items.Add(registro["IdSeccion"].ToString());

            }
            conexion.Close();
        }

        private void RegistrarAlumno_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT Grado FROM Grados", conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                cbGrado.Items.Add(registro["Grado"].ToString());
            }
            conexion.Close();
            cbGrado.Enabled = true;
            cbSeccion.Enabled = true;
        }
    }
}
