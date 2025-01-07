using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMauiApp
{
    internal class ViewModel : BindableObject
    {
        private string[] questionContent = ["Kiedy byla bitwa pod Grundwaldem",
            "Ile wynosi f`(x) od f(x) = 1/5 x^5 + 1/4 x^4 + 2/3 x^3 + 4. Podaj x pochodnej",
            "Co to za znak: Σ", 
            "Ile wynosi masa slonca"];
        private string[,] answersContent = { 
            { "pazdziernik 1410", "lipiec 1410", "wrzesien 1410", "listopad 1410" }, 
            { "0,-2,1", "3,5", "-2,1,3", "-5,-2,0" }, 
            { "Omega", "Alfa", "Sigma", "Beta" }, 
            { "Co najmniej jedno slonce", "Z milion ziem ", "100 ksiezycow", "1000 Jowiszy" } 
        };
        private string[] correctAnswers = ["lipiec 1410", "0,-2,1", "Sigma", "Co najmniej jedno slonce"];

        private static int score = 0;

        private bool isCorrectOne;
        public bool IsCorrectOne
        {
            get { return isCorrectOne; }
            set { isCorrectOne = value; }
        }


        private string answerOne = "";
        public string AnswerOne
        {
            get { return answerOne; }
            set { answerOne = answersContent[questionNumber, 0]; OnPropertyChanged(); }
        }

        private string answerTwo = "";
        public string AnswerTwo
        {
            get { return answerTwo; }
            set { answerTwo = answersContent[questionNumber, 1]; OnPropertyChanged(); }
        }

        private string answerThree = "";
        public string AnswerThree
        {
            get { return answerThree; }
            set { answerThree = answersContent[questionNumber, 2]; OnPropertyChanged(); }
        }

        private string answerFour = "";
        public string AnswerFour
        {
            get { return answerFour; }
            set { answerFour = answersContent[questionNumber, 3]; OnPropertyChanged(); }
        }

        private int questionNumber = 0;
        public int QuestionNumber
        {
            get { return questionNumber; }
            set { questionNumber = value; }
        }

        private string questionText = "1";
        public string QuestionText
        {
            get { return questionText; }
            set { questionText = questionContent[QuestionNumber]; OnPropertyChanged(); }
        }

        private Command previousQuestion = null;
        public Command PreviousQuestion
        {
            get { return previousQuestion; }
            set { previousQuestion = value; }
        }

        private Command nextQuestion = null;
        public Command NextQuestion
        {
            get { return nextQuestion; }
            set { nextQuestion = value; }
        }

        private Command checkCorrectAnswer;

        public Command CheckCorrectAnswer
        {
            get { return checkCorrectAnswer; }
            set { checkCorrectAnswer = value; }
        }


        public ViewModel()
        {
            QuestionText = "";
            AnswerOne = "";
            AnswerTwo = "";
            AnswerThree = "";
            AnswerFour = "";
            PreviousQuestion = new Command(PreviousQuestionM);
            NextQuestion = new Command(NextQuestionM);
            CheckCorrectAnswer = new Command(CheckCorrectAnswerM);
        }

        private void PreviousQuestionM()
        {
            QuestionNumber--;
            if (QuestionNumber < 0)
            {
                QuestionNumber = questionContent.Length - 1;
            }
            QuestionText = "";
            AnswerOne = "";
            AnswerTwo = "";
            AnswerThree = "";
            AnswerFour = "";
        }

        private void NextQuestionM()
        {
            QuestionNumber++;
            if (QuestionNumber > questionContent.Length - 1)
            {
                QuestionNumber = 0;
            }
            QuestionText = "";
            AnswerOne = "";
            AnswerTwo = "";
            AnswerThree = "";
            AnswerFour = "";
        }
        private void CheckCorrectAnswerM()
        {
            if (correctAnswers[questionNumber] == CheckAnswersM())
            {
                score++;
            };
            return;
        }

        private string CheckAnswersM()
        {
            if (isCorrectOne == true)
            {
                return answersContent[questionNumber, 1];
            }
            else
            {
                return "";
            }
        }

    }
}
