namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Wyszukaj());
        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LISTA());
        }
    }

}
