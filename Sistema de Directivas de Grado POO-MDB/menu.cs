﻿using System;
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Alumnos_Click(object sender, EventArgs e)
        {
            AlumnosForm form = new AlumnosForm();
            form.Show();
            this.Hide();
        }
    }
}
