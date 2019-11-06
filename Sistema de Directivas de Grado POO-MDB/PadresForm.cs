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
    public partial class PadresForm : Form
    {
        public PadresForm()
        {
            InitializeComponent();
        }

        private void PadresForm_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT PrimerNombre, SegundoNombre, TercerNombre, PrimerApellido, SegundoApellido, Telefono, Email FROM Personas per" +
                " INNER JOIN Padres pa ON per.IdPersona = pa.IdPersona", conexion);
            comando.Parameters.Clear();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvListado.DataSource = dt;
            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistrarPadre form = new RegistrarPadre();
            form.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            form.Show();
            this.Hide();
        }
    }
}
