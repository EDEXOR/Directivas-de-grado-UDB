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

            Clock.Interval = 5000;
            Clock.Start();
            Clock.Tick += new EventHandler(Timer_Tick);
            

        }
        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            Clock.Stop();
            frmLogin form_log = new frmLogin();
            this.Hide();
            form_log.Show();           
        }

        
        

    }
}
