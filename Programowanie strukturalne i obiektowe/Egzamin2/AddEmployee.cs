namespace Egzamin2
{
    public partial class FormAddEmployee : Form
    {
        string UserPassword;
        public FormAddEmployee()
        {
            InitializeComponent();
        }
        private void buttonPassword_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            int passwordLength = int.Parse(textBoxHowMuch.Text);

            string password = "";

            string specialSings = "!@#$%^&*()_+-=";

            for (int i = 0; i < passwordLength; i++)
            {

                if (i == 0 && checkBoxSmallAndBig.Checked)
                {
                    password += (char)(random.Next('A', 'Z' + 1));
                }
                else if (i == 1 && checkBoxNumbers.Checked)
                {
                    password += random.Next(0, 10);
                }
                else if (i == 2 && checkBoxSpecialCharacters.Checked)
                {
                    password += specialSings[random.Next(0, specialSings.Length)];
                }
                else {
                    password += (char)random.Next('a', 'z' + 1);
                }
            }
            MessageBox.Show(password);
            UserPassword = password;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string position = comboBoxPosition.Text;
            string password = UserPassword;

            MessageBox.Show($"Dane pracownika: {name} {surname} {position} Has³o: {password}");
        }

    }
}