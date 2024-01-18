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
    public partial class Valikko : Form
    {
        public Valikko()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Havut havu1 = new Havut();

            havu1.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Huonekasvit huonekasvit = new Huonekasvit();

            huonekasvit.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Hyotykasvit Hyotykasvit = new Hyotykasvit();

            Hyotykasvit.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Kesakukat Kesakukat = new Kesakukat();

            Kesakukat.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Koynnokset köynnökset = new Koynnokset();

            köynnökset.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Pensaat pensaat = new Pensaat();

            pensaat.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Liljat liljat = new Liljat();

            liljat.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Perennat Perennat = new Perennat();

            Perennat.ShowDialog();
        }

    }
}
