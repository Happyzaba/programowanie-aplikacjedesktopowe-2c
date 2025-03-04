using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMauiApp
{
    internal class EgzaminViewModel : BindableObject
    {
        private string showResult;
        public string ShowResult
        {
            get { return showResult; }
            set { showResult = value; OnPropertyChanged(); }
        }
        private string showWholeGameResult;
        public string ShowWholeGameResult
        {
            get { return showWholeGameResult; }
            set { showWholeGameResult = value; OnPropertyChanged(); }
        }
        private string dice1;

        public string Dice1
        {
            get { return dice1; }
            set { dice1 = value; OnPropertyChanged(); }
        }
        private string dice2;

        public string Dice2
        {
            get { return dice2; }
            set { dice2 = value; OnPropertyChanged(); }
        }
        private string dice3;

        public string Dice3
        {
            get { return dice3; }
            set { dice3 = value; OnPropertyChanged(); }
        }
        private string dice4;

        public string Dice4
        {
            get { return dice4; }
            set { dice4 = value; OnPropertyChanged(); }
        }
        private string dice5;

        public string Dice5
        {
            get { return dice5; }
            set { dice5 = value; OnPropertyChanged(); }
        }
        private Command resetCommand;

        public Command ResetCommand
        {
            get { return resetCommand; }
            set { resetCommand = value; }
        }

        private Command throwCommand;

        public Command ThrowCommand
        {
            get { return throwCommand; }
            set { throwCommand = value; }
        }
        public EgzaminViewModel()
        {
            ThrowCommand = new Command(ThrowDice);
            ResetCommand = new Command(ResetGame);
            ResetCommand.Execute(this);
        }
        private string[] diceImages =
        {
            "k1.jpg",
            "k2.jpg",
            "k3.jpg",
            "k4.jpg",
            "k5.jpg",
            "k6.jpg",
        };
        int gameResult = 0;
        public void ThrowDice()
        {
            Random random = new Random();

            int[] diceValues = new int[5]
            {
                random.Next(1,7),
                random.Next(1,7),
                random.Next(1,7),
                random.Next(1,7),
                random.Next(1,7)
            };

            Dice1 = diceImages[diceValues[0] - 1];
            Dice2 = diceImages[diceValues[1] - 1];
            Dice3 = diceImages[diceValues[2] - 1];
            Dice4 = diceImages[diceValues[3] - 1];
            Dice5 = diceImages[diceValues[4] - 1];

            var duplicates = diceValues.GroupBy(x => x).Where(g => g.Count() > 1).SelectMany(g => g);
            int total = duplicates.Sum();

            gameResult = gameResult + total;
            ShowResult = $"Wynik tego losowania {total}";
            ShowWholeGameResult = $"Wynik całej gry {gameResult}";
        }
        public void ResetGame()
        {
            Dice1 = "question.jpg";
            Dice2 = "question.jpg";
            Dice3 = "question.jpg";
            Dice4 = "question.jpg";
            Dice5 = "question.jpg";
            ShowResult = $"Wynik tego losowania 0";
            gameResult = 0;
            ShowWholeGameResult = $"Wynik całej gry 0";
        }
    }

}
