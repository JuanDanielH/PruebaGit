﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGit
{
    public partial class MenuOpciones : Form
    {
        public MenuOpciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumerosRomanos NR = new NumerosRomanos();
            NR.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCalculadora Ca = new frmCalculadora();
            Ca.Show();
            this.Hide();
        }
    }
}
