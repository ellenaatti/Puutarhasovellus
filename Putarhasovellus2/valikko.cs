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
    public partial class valikko : Form
    {
        public valikko()
        {
            InitializeComponent();
        }

        private void Havukasvit_Click(object sender, EventArgs e)
        {
            havut havu1 = new havut();

            havu1.ShowDialog();

        }

        private void Huonekasvit_Click(object sender, EventArgs e)
        {
            huonekasvit huonekasvit = new huonekasvit();

            huonekasvit.ShowDialog();
        }

        private void Köynnökset_Click(object sender, EventArgs e)
        {
            köynnökset köynnökset = new köynnökset();

            köynnökset.ShowDialog();
        }

        private void Pensaat_Click(object sender, EventArgs e)
        {

        }

        private void Liljat_Click(object sender, EventArgs e)
        {
            liljat liljat = new liljat();

            liljat.ShowDialog();
        }

        private void Pensat_Click(object sender, EventArgs e)
        {

        }

        private void hyotykasvit_Click(object sender, EventArgs e)
        {
            hyotykasvit hyotykasvit = new hyotykasvit();

            hyotykasvit.ShowDialog();
        }

        private void kesakukat_Click(object sender, EventArgs e)
        {
            kesakukat kesakukat = new kesakukat();

            kesakukat.ShowDialog();
        }

    }
}
