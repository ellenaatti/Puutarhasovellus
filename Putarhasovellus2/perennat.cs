﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Putarhasovellus2
{
    public partial class Perennat : Form
    {
        public Perennat()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Valikko valikko = new Valikko();

            this.Close();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            Perennatt perennatt1 = new Perennatt();

            perennatt1.Show();
            this.Hide();
        }
    }
}