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
    public partial class RegistrarPadre : Form
    {
        public RegistrarPadre()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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

                SqlCommand codPa = new SqlCommand("SELECT COUNT(*) FROM Padres", conexioon);
                codPa.Parameters.Clear();
                int CantidadPa = Convert.ToInt32(codPa.ExecuteScalar()) + 1;

                String codigoPa = "";

                if (CantidadPa < 10)
                {
                    codigoPa = ("PA000" + CantidadPa.ToString());
                }
                else if (CantidadPa >= 10 && CantidadPa < 100)
                {
                    codigoPa = ("PA00" + CantidadPa.ToString());
                }
                else if (CantidadPa >= 100 && CantidadPa < 1000)
                {
                    codigoPa = ("PA0" + CantidadPa.ToString());
                }
                else if (CantidadPa >= 1000 && CantidadPa < 10000)
                {
                    codigoPa = ("PA" + CantidadPa.ToString());
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
                SqlCommand com = new SqlCommand("INSERT INTO Padres VALUES(@codigoPr, @codigoP)", conexioooon);
                com.Parameters.Clear();

                com.Parameters.AddWithValue("@codigoPr", codigoPa);
                com.Parameters.AddWithValue("@codigoP", codigoP);
                SqlDataReader drr = com.ExecuteReader();
                conexioooon.Close();

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
                listaErrores.SetError(txtPrimerNombre, "Ingrese el nombre del padre");
            }
            if (txtPrimerApellido.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtPrimerApellido, "Ingrese el apellido del padre");
            }
            if (txtTelefono.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtTelefono, "Ingrese el teléfono del padre");
            }
            if (txtCorreo.Text == String.Empty)
            {
                bandera = false;
                listaErrores.SetError(txtCorreo, "Ingrese el correo del padre");
            }
            return bandera;
        }
    }
}
