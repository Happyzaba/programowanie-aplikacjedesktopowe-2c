namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            MessageBox.Show($"Witaj {name} w pierwszym programie", "Komunikat",
                MessageBoxButtons.OK);

        }
    }
}