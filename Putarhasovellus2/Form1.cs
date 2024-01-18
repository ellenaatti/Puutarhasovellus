namespace Putarhasovellus2
{
    public partial class Eka : Form
    {
        public Eka()
        {
            InitializeComponent();
        }

        private void valikkobtn_Click(object sender, EventArgs e)
        {
            Valikko valikko1 = new Valikko();

            valikko1.Show();
            this.Hide();
        }
    }
}
