namespace Egzamin2
{
    public partial class FormAddEmployee : Form
    {
        string userPassword = "";
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
            string smallLetters = "abcdefghijklmnoprstuvxyz";
            string bigLetters = "ABCDEFGHIJKLMNOPRSTUVXYZ";
            string numbers = "0123456789";

            for (int i = 0; i < passwordLength; i++) {
                if (i == 0 && checkBoxSmallAndBig.Checked) {
                    password += bigLetters[random.Next(bigLetters.Length)];
                }
                else if (i == 1 && checkBoxNumbers.Checked) {
                    password += numbers[random.Next(numbers.Length)];
                }
                else if (i == 2 && checkBoxSpecialCharacters.Checked) {
                    password += specialSings[random.Next(specialSings.Length)];
                }
                else {
                    password += smallLetters[random.Next(smallLetters.Length)];
                }
            }
            MessageBox.Show(password);
            userPassword = password;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string position = comboBoxPosition.Text;
            string password = userPassword;

            MessageBox.Show($"Dane pracownika: {name} {surname} {position} Has³o: {password}");
        }

    }
}