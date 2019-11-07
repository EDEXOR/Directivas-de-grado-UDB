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
        private int edit_indice = -1;
        public AlumnosForm()
        {
            InitializeComponent();
        }

        private void AlumnosForm_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT IdGrado, Grado FROM Grados", conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                cmbGrado.ValueMember = registro["IdGrado"].ToString();
                cmbGrado.Items.Add(registro["Grado"].ToString());
            }
            conexion.Close();
        }

        private void CmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeccion.Items.Clear();
            cmbSeccion.Enabled = true;
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT IdSeccion, Seccion FROM Secciones sec INNER JOIN Grados gra ON sec.IdGrado = gra.IdGrado WHERE gra.Grado=@grado", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@grado", Int32.Parse(cmbGrado.Text));
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cmbSeccion.ValueMember = registro["IdSeccion"].ToString();
                cmbSeccion.Items.Add(registro["Seccion"].ToString());
            }
            conexion.Close();
        }

        private void CmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexion.conectar();
            SqlCommand comando = new SqlCommand("SELECT sec.IdSeccion, alu.Carnet, per.PrimerNombre, per.SegundoNombre, per.PrimerApellido, per.SegundoApellido FROM Alumnos alu" +
                " INNER JOIN Personas per ON alu.IdPersona = per.IdPersona" +
                " INNER JOIN Secciones sec ON alu.IdSeccion = sec.IdSeccion WHERE sec.IdSeccion = @seccion", conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@seccion", cmbSeccion.ValueMember.ToString());
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvListado.DataSource = dt;


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
            frmMenu form = new frmMenu();
            form.Show();
            this.Hide();
        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            string id = dgvListado.CurrentRow.Cells[0].Value.ToString();
            ModificarAlumno form = new ModificarAlumno();
            form.carnet = id;
            form.Show();
            this.Hide();
        }
    }
}
