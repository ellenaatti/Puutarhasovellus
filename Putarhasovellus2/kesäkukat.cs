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
    public partial class kesakukat : Form
    {
        public kesakukat()
        {
            InitializeComponent();
        }

        private void takaisinbtn3_Click(object sender, EventArgs e)
        {
            valikko valikko = new valikko();

            this.Close();
        }
    }
}
