namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //comboBoxFavouriteMeal.SelectedIndex = 2;
            InitializeComponent();
            comboBoxFavouriteMeal.SelectedIndex = 2;

            labelCurentTime.Text = DateTime.Now.ToString();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            string schoolSubject = "Ulubione przedmioty:\n";
            if (checkBoxSchoolSubjectMathematics.Checked)
            {
                schoolSubject += "matematyka\n";
            }
            if (checkBoxSchoolSubjectGerman.Checked)
            {
                schoolSubject += "jêzyk niemiecki\n";
            }

            string pizzaWithPineapple = "";
            if (radioButtonPizzaQuestionYes.Checked)
            {
                pizzaWithPineapple = "Lubiê pizze z ananasem.";
            }
            else
            {
                pizzaWithPineapple = "Pizza z ananasem to nieporozumienie";
            }

            string favouriteMeal = comboBoxFavouriteMeal.Text;

            MessageBox.Show(
                $"Witaj {name} w pierwszym programie.\n {schoolSubject}"
                + $"\n{pizzaWithPineapple}"
                + $"\nUlubiona potrawa: {favouriteMeal}",
                "Komunikat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
        }

        private void buttonRefreshTime_Click(object sender, EventArgs e)
        {
            labelCurentTime.Text = DateTime.Now.ToString();
        }

        private void timerRefreshTime_Tick(object sender, EventArgs e)
        {
            labelCurentTime.Text = DateTime.Now.ToString();
        }

        private void labelMouseClick_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                labelMouseClick.Text = "Kliknieto lewy przycisk";
            if (e.Button == MouseButtons.Right)
                labelMouseClick.Text = "Kliknieto prawy przycisk";
        }
        private void operation_Click(object sender, EventArgs e)
        {
            Decimal firstNumber = numericUpDownFirstNumber.Value;
            Decimal secondNumber = numericUpDownSecondNumber.Value;

            Decimal result = 0;
           
            Button button = sender as Button;
            if (button == null)
                return;

            string operation = button.Text;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }
            labelResult.Text = "Wynik:" + result.ToString();
        }
    }
}