namespace Egzamin2
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string position = comboBoxPosition.Text;

            MessageBox.Show($"Dane pracownika: {name} {surname} {position} Has³o: ");
        }
    }
}