namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object? sender, EventArgs e)
        {
            var win2 = new Window(new SecondPage());
            Application.Current?.OpenWindow(win2);

            var win3 = new Window(new SecondPage());
            Application.Current?.OpenWindow(win3);

            var win4 = new Window(new SecondPage());
            Application.Current?.OpenWindow(win4);

            var win5 = new Window(new SecondPage());
            Application.Current?.OpenWindow(win5);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current?.Quit();
        }
    }

}
