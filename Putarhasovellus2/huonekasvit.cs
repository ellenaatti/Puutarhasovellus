using System;
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
    public partial class Greenery : Form
    {
        public Greenery()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.Show();
        }
    }
}
