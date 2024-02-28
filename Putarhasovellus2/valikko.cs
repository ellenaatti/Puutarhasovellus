using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Putarhasovellus2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Valitse kasvilaji");
                return;
            }

            switch (listBox1.SelectedItem.ToString())
            {
                case "Havut":
                    Conifer conifer = new Conifer();
                    conifer.Show();
                    this.Hide();
                    break;

                case "Liljat":
                    Lilys lilys = new Lilys();
                    lilys.Show();
                    this.Hide();
                    break;

                case "Kesäkukat":
                    Summerflower summerflower = new Summerflower();
                    summerflower.Show();
                    this.Hide();
                    break;

                case "Huonekasvit":
                    Greenery greenery = new Greenery();
                    greenery.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
