using Microsoft.Maui.Graphics.Text;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;

namespace UnitsChangerMauiApp
{
    public partial class MainPage : ContentPage
    {
        public List<string> UnitsList { get; set; }
        public string FirstSelectedUnit { get; set; }
        public string SecondSelectedUnit { get; set; }
        public string ChangedUnit { get; set; }

        private string changedUnitMessage;

        public string ChangedUnitMessage
        {
            get { return changedUnitMessage; }
            set { 
                changedUnitMessage = value;
                OnPropertyChanged();
            }
        }


        public MainPage()
        {
            UnitsList = new List<string>();
            UnitsList.Add("mm");
            UnitsList.Add("cm");
            UnitsList.Add("m");
            UnitsList.Add("km");

            FirstSelectedUnit = UnitsList.First();
            SecondSelectedUnit = UnitsList.First();
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(ChangedUnit);

            switch (FirstSelectedUnit)
            {
                case "mm":
                    switch (SecondSelectedUnit)
                    {
                        case "mm":
                            ChangedUnitMessage = "Liczba po zamianie " + result + SecondSelectedUnit;
                            break;

                        case "cm":
                            ChangedUnitMessage = "Liczba po zamianie " + result * 0.1 + SecondSelectedUnit;
                            break;

                        case "m":
                            ChangedUnitMessage = "Liczba po zamianie " + result * 0.001 + SecondSelectedUnit;
                            break;

                        case "km":
                            ChangedUnitMessage = "Liczba po zamianie " + result * 0.000001 + SecondSelectedUnit;
                            break;
                    }
                    break;
                case "cm":
                    if (SecondSelectedUnit == "mm") {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 10 + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "cm")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "m")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 0.01 + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "km")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 0.00001 + SecondSelectedUnit;
                    }
                    break;
                case "m":
                    if (SecondSelectedUnit == "mm")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 1000 + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "cm")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 100 + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "m")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "km")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 0.001 + SecondSelectedUnit;
                    }
                    break;
                case "km":
                    if (SecondSelectedUnit == "mm")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 1000000 + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "cm")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 100000 + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "m")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result * 1000 + SecondSelectedUnit;
                    }
                    if (SecondSelectedUnit == "km")
                    {
                        ChangedUnitMessage = "Liczba po zamianie " + result + SecondSelectedUnit;
                    }
                    break;
                default:
                    break;
            }

        }
    }

}
