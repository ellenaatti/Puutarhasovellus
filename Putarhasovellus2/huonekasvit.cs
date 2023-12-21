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
    public partial class huonekasvit : Form
    {
        public huonekasvit()
        {
            InitializeComponent();
        }

        private void takaisinbtn2_Click(object sender, EventArgs e)
        {
            valikko valikko = new valikko();

            this.Close();


        }
    }
}
