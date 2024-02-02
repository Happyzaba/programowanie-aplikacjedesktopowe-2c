namespace Egzamin
{
    public partial class LoginApp : Form
    {
        public LoginApp()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string name = textBoxMail.Text;

            MessageBox.Show($"Witaj {name}");
        }
    }
}