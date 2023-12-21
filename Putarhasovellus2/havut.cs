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
    public partial class havut : Form
    {
        public havut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valikko valikko = new valikko();

            this.Close();
        }
    }
}
