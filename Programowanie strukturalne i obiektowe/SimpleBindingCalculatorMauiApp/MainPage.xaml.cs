﻿namespace SimpleBindingCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string Value { get; set; }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            
            int firstNumber;
            if (!int.TryParse(strFirstNumber, out firstNumber))
            {
                //komunikat o błędzie
                resultLabel.Text = "Niepoprawna pierwsza liczba";
                resultLabel.TextColor = Colors.Red;
                return;
            }

            if (!int.TryParse(secondNumberEntry.Text, out int secondNumber))
            {
                //komunikat o błędzie
                resultLabel.Text = "Niepoprawna druga liczba";
                resultLabel.TextColor = Colors.Red;
                return;
            }

            int result = 0;
            if (operationAddRadioButton.IsChecked)
            {
                result = firstNumber + secondNumber;
            }
            else if (operationSubRadioButton.IsChecked)
            {
                result = firstNumber - secondNumber;
            }
            else if (operationMulRadioButton.IsChecked)
            {
                result = firstNumber * secondNumber;
            }
            else if (operationDivRadioButton.IsChecked)
            {
                result = firstNumber / secondNumber;
            }
            resultLabel.Text = "Wartość" + Value;
            resultLabel.TextColor = Colors.Pink;
        }
    }
}
