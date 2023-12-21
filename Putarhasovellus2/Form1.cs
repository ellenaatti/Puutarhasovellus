namespace Putarhasovellus2
{
    public partial class eka : Form
    {
        public eka()
        {
            InitializeComponent();
        }

        private void valikkobtn_Click(object sender, EventArgs e)
        {
            valikko valikko1 = new valikko();

            valikko1.Show();
            this.Hide();
        }
    }
}
