namespace BindingMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string Message { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            rotationLabel.Rotation = rotationSlider.Value;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lab.Text = "Wartość z entry " + Message;
        }
    }

}
