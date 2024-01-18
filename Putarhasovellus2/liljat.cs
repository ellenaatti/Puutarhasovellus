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
    public partial class Liljat : Form
    {
        public Liljat()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Valikko valikko = new Valikko();

            this.Close();
        }
    }
}
