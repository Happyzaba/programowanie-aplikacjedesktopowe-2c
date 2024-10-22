using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterMauiApp
{
    public class TemperatureViewModel : BindableObject
    {
        public List<string> TemperatureList { get; set; }
        public string FirstSelectedTemperature { get; set; }
        public string SecondSelectedTemperature { get; set; }
        public string ChangedTemp { get; set; }

        private string changedTempMessage;

        public string ChangedTempMessage
        {
            get { return changedTempMessage; }
            set { changedTempMessage = value;
                OnPropertyChanged();
            }
        }
        public Command ButtonClicked { get; set; }

        public TemperatureViewModel(){
            ButtonClicked = new Command(ChangeTemperature); 
            TemperatureList = new List<string>();
            TemperatureList.Add("C");
            TemperatureList.Add("F");
            FirstSelectedTemperature = TemperatureList.First();
            SecondSelectedTemperature = TemperatureList.First();
        }
        public void ChangeTemperature()
        { 
           double result = Convert.ToDouble(ChangedTemp);

            switch(FirstSelectedTemperature){
                case "C":
                    if (SecondSelectedTemperature == "C") {
                        ChangedTempMessage = "Temperatura po zmianie " + result + SecondSelectedTemperature;
                    }     
                    if (SecondSelectedTemperature == "F") {
                        result = (result *9/5) + 32;
                        ChangedTempMessage = "Temperatura po zmianie " + result + SecondSelectedTemperature;
                    }
                    break;
                case "F":
                    if (SecondSelectedTemperature == "C")
                    {
                        result = (result - 32) * 5/9;
                        ChangedTempMessage = "Temperatura po zmianie " + result + SecondSelectedTemperature;
                    }
                    if (SecondSelectedTemperature == "F")
                    {
                        ChangedTempMessage = "Temperatura po zmianie " + result + SecondSelectedTemperature;
                    }
                    break;
            }
            

        }


    }
}
