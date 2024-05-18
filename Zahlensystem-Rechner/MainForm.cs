namespace Zahlensystem_Rechner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        // Switches to the "Umwandeln" form
        private void btn_openUmwandeln_Click(object sender, EventArgs e)
        {
            this.Hide();
            Umwandeln umwandeln = new Umwandeln();
            umwandeln.Show();

        }

        // Ends the applications the the exit button is pressed
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Switches to the "Rechner" form
        private void btn_OpenRechnerForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rechner rechner = new Rechner();
            rechner.Show();
        }
    }
}
