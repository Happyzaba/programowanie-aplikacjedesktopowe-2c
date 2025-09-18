using Windows.Services.Maps;

namespace TabPageMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            TabbedPage tabbedPage = new TabbedPage();

            tabbedPage.Children.Add(new MainPage());
            tabbedPage.Children.Add(new AboutPage());
            tabbedPage.Children.Add(new Another());

            return new Window(tabbedPage);
        }
    }
}