namespace Putarhasovellus2
{
    public partial class Eka : Form
    {
        public Eka()
        {
            InitializeComponent();
            Thread thread = new Thread(CloseAfterTime);
            thread.Start();
        }

        private void valikkobtn_Click(object sender, EventArgs e)
        {
            Menu valikko1 = new Menu();

            valikko1.Show();
            this.Hide();
        }

        private const int maxTime = 200;

        private void CloseAfterTime()
        {
            int elapsedTime = 0;

            while (true)
            {
                Thread.Sleep(1000); // Odota yksi sekunti

                elapsedTime++;

                if (elapsedTime >= maxTime)
                {
                    CloseForm();
                    break;
                }
            }
        }

        private void CloseForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CloseForm));
            }
            else
            {
                MessageBox.Show("Ohjelma sammutetaan.");
                Close();
            }
        }
    }
}
