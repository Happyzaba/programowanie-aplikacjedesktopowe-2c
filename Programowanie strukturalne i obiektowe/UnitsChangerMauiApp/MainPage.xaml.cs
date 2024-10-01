using System.Collections.ObjectModel;

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


            ChangedUnitMessage = " Liczba po zamianie " + SecondSelectedUnit;
        }
    }

}
