using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        Timer Clock = new Timer();
        private void inicio_Load(object sender, EventArgs e)
        {

            Clock.Interval = 3000;
            Clock.Start();
            Clock.Tick += new EventHandler(Timer_Tick);
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        
        }
        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            Clock.Stop();
            login form_log = new login();
            form_log.Show();


            Inicio form1 = new Inicio();
            this.Hide();

        }

        
        

    }
}
