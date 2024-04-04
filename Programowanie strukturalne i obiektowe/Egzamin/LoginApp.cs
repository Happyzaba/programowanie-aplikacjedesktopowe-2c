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
            string password = textBoxPassword.Text;
            string repeat = textBoxRepeat.Text;

            labelComunication.Text = "";

            if (name.Contains('@'))
            {

                if (password == repeat)
                {
                    labelComunication.Text += "Autor:00000000000" + System.Environment.NewLine;
                    labelComunication.Text += ($"Witaj {name}") + System.Environment.NewLine;
                }
                else
                {
                    labelComunication.Text += ("Has³a siê ró¿ni¹");
                }
            }
            else
            {
                labelComunication.Text += ("Nieprawid³owy adres e-mail");
            }

        }
    }
}