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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            limpiarErrores();
            if (validarCampos())
            {
                SqlConnection conexion = Conexion.conectar();

                SqlCommand codP = new SqlCommand("SELECT COUNT(*) FROM Personas", conexion);
                codP.Parameters.Clear();
                int CantidadP = Convert.ToInt32(codP.ExecuteScalar()) + 1;

                String codigoP = "";

                if (CantidadP < 10)
                {
                    codigoP = ("P0000" + CantidadP.ToString());
                }
                else if (CantidadP >= 10 && CantidadP < 100)
                {
                    codigoP = ("P000" + CantidadP.ToString());
                }
                else if (CantidadP >= 100 && CantidadP < 1000)
                {
                    codigoP = ("P00" + CantidadP.ToString());
                }
                else if (CantidadP >= 1000 && CantidadP < 10000)
                {
                    codigoP = ("P0" + CantidadP.ToString());
                }
                conexion.Close();

                SqlConnection conexioon = Conexion.conectar();

                SqlCommand codA = new SqlCommand("SELECT COUNT(*) FROM Alumnos", conexioon);
                codA.Parameters.Clear();
                int CantidadA = Convert.ToInt32(codA.ExecuteScalar()) + 1;

                String codigoA = "";

                if (CantidadA < 10)
                {
                    codigoA = ("A0000" + CantidadA.ToString());
                }
                else if (CantidadA >= 10 && CantidadA < 100)
                {
                    codigoA = ("A000" + CantidadA.ToString());
                }
                else if (CantidadA >= 100 && CantidadA < 1000)
                {
                    codigoA = ("A00" + CantidadA.ToString());
                }
                else if (CantidadA >= 1000 && CantidadA < 10000)
                {
                    codigoA = ("A0" + CantidadA.ToString());
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
            else
            {
                MessageBox.Show("Debe revisar los datos ingresados");
            }

        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
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
                cbSeccion.Items.Add(registro["Seccion"].ToString());

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtTercerNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCarnet.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void limpiarErrores()
        {
            listaErrores.SetError(txtPrimerNombre, "");
            listaErrores.SetError(txtPrimerApellido, "");
            listaErrores.SetError(txtCarnet, "");
        }

        private bool validarCampos()
        {
            bool bandera = true;
            if (txtPrimerNombre.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtPrimerNombre, "Ingrese el nombre del estudiante");
            }
            if (txtPrimerApellido.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtPrimerApellido, "Ingrese el apellido del estudiante");
            }
            if (txtCarnet.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtCarnet, "Ingrese el carnet del estudiante");
            }
            if (!Validaciones.ValidarTelefono(txtTelefono.Text))
            {
                bandera = false;
                listaErrores.SetError(txtTelefono, "Ingrese un teléfono válido");
            }
            if (!Validaciones.ValidarEmail(txtCorreo.Text))
            {
                bandera = false;
                listaErrores.SetError(txtCorreo, "Ingrese un correo válido");
            }
            if (!Validaciones.ValidarCarnet(txtCarnet.Text))
            {
                bandera = false;
                listaErrores.SetError(txtCarnet, "Ingrese un carnet válido");
            }
            return bandera;
        }
    }
}
