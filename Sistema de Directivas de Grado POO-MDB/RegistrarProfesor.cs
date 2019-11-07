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
    public partial class RegistrarProfesor : Form
    {
        public RegistrarProfesor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            limpiarErrores();
            if (validarCampos())
            {
                SqlConnection conexion1 = Conexion.conectar();

                SqlCommand codP = new SqlCommand("SELECT COUNT(*) FROM Personas", conexion1);
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
                conexion1.Close();

                SqlConnection conexion2 = Conexion.conectar();

                SqlCommand codPr = new SqlCommand("SELECT COUNT(*) FROM Profesores", conexion2);
                codPr.Parameters.Clear();
                int CantidadPr = Convert.ToInt32(codPr.ExecuteScalar()) + 1;

                String codigoPr = "";

                if (CantidadPr < 10)
                {
                    codigoPr = ("PR000" + CantidadPr.ToString());
                }
                else if (CantidadPr >= 10 && CantidadPr < 100)
                {
                    codigoPr = ("PR00" + CantidadPr.ToString());
                }
                else if (CantidadPr >= 100 && CantidadPr < 1000)
                {
                    codigoPr = ("PR0" + CantidadPr.ToString());
                }
                else if (CantidadPr >= 1000 && CantidadPr < 10000)
                {
                    codigoPr = ("PR" + CantidadPr.ToString());
                }
                conexion2.Close();

                SqlConnection conexion3 = Conexion.conectar();

                SqlCommand codU = new SqlCommand("SELECT COUNT(*) FROM Usuarios", conexion3);
                codU.Parameters.Clear();
                int CantidadU = Convert.ToInt32(codU.ExecuteScalar()) + 1;

                String codigoU = "";

                if (CantidadU < 10)
                {
                    codigoU = ("U0000" + CantidadU.ToString());
                }
                else if (CantidadPr >= 10 && CantidadU < 100)
                {
                    codigoU = ("U000" + CantidadU.ToString());
                }
                else if (CantidadPr >= 100 && CantidadU < 1000)
                {
                    codigoU = ("U00" + CantidadU.ToString());
                }
                else if (CantidadPr >= 1000 && CantidadU < 10000)
                {
                    codigoU = ("U0" + CantidadU.ToString());
                }
                conexion3.Close();

                SqlConnection conexion4 = Conexion.conectar();
                SqlCommand cm1 = new SqlCommand("INSERT INTO Personas VALUES(@codigoP, @PrimerNombre, @SegundoNombre, @TercerNombre, @PrimerApellido, @SegundoApellido, @tel, @email)", conexion4);
                cm1.Parameters.Clear();

                cm1.Parameters.AddWithValue("@codigoP", codigoP);
                cm1.Parameters.AddWithValue("@PrimerNombre", txtPrimerNombre.Text);
                cm1.Parameters.AddWithValue("@SegundoNombre", txtSegundoNombre.Text);
                cm1.Parameters.AddWithValue("@TercerNombre", txtTercerNombre.Text);
                cm1.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                cm1.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                cm1.Parameters.AddWithValue("@tel", txtTelefono.Text);
                cm1.Parameters.AddWithValue("@email", txtCorreo.Text);
                SqlDataReader dr1 = cm1.ExecuteReader();
                conexion4.Close();

                SqlConnection conexion5 = Conexion.conectar();
                SqlCommand cm2 = new SqlCommand("INSERT INTO Profesores VALUES(@codigoPr, @codigoP)", conexion5);
                cm2.Parameters.Clear();

                cm2.Parameters.AddWithValue("@codigoPr", codigoPr);
                cm2.Parameters.AddWithValue("@codigoP", codigoP);
                SqlDataReader drr = cm2.ExecuteReader();
                conexion5.Close();

                SqlConnection conexion6 = Conexion.conectar();
                SqlCommand cm3 = new SqlCommand("INSERT INTO Usuarios VALUES(@codigoU, @codigoPr, @TipoUsuario, @correo, @clave)", conexion6);
                cm3.Parameters.Clear();

                cm3.Parameters.AddWithValue("@codigoU", codigoU);
                cm3.Parameters.AddWithValue("@codigoPr", codigoPr);
                cm3.Parameters.AddWithValue("@TipoUsuario", 2);
                cm3.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cm3.Parameters.AddWithValue("@clave", "clave");
                SqlDataReader drrr = cm3.ExecuteReader();
                conexion6.Close();

                MessageBox.Show("Se agrego bien paloma", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe revisar los datos ingresados");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtTercerNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void limpiarErrores()
        {
            listaErrores.SetError(txtPrimerNombre, "");
            listaErrores.SetError(txtPrimerApellido, "");
            listaErrores.SetError(txtTelefono, "");
            listaErrores.SetError(txtCorreo, "");
        }

        private bool validarCampos()
        {
            bool bandera = true;
            if (txtPrimerNombre.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtPrimerNombre, "Ingrese el nombre del profesor");
            }
            if (txtPrimerApellido.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtPrimerApellido, "Ingrese el apellido del profesor");
            }
            if (txtTelefono.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtTelefono, "Ingrese el teléfono del profesor");
            }
            if (txtCorreo.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtCorreo, "Ingrese el correo del profesor");
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
            return bandera;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ProfesoresForm form = new ProfesoresForm();
            form.Show();
            this.Hide();
        }
    }
}
