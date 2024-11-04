namespace MauiApp2
{
    public partial class Wyszukaj : ContentPage
    {
        public Wyszukaj()
        {
            InitializeComponent();
        }

        private void OnAdditionalOptionsSwitchToggled(object sender, ToggledEventArgs e)
        {
            CityPickerEnd.IsVisible = e.Value;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            Label sendingOrderLabel = new Label { Text = "Trwa wysy�anie zam�wienia", HorizontalOptions = LayoutOptions.Center };
            ProgressBar progressBar = new ProgressBar { Progress = 0 };
            StackLayout stackLayout = new StackLayout
            {
                Children = { sendingOrderLabel, progressBar }
            };
            this.Content = stackLayout;

            for (int i = 0; i <= 100; i++)
            {
                progressBar.Progress = i / 100.0;
                await Task.Delay(50); // 50ms * 100 = 5000ms = 5 seconds
            }

            await DisplayAlert("Powiadomienie", "Uda�o si� zam�wi� taryfe byczqu", "OK");
            await Navigation.PushAsync(new MainPage());
        }

        private void OnPassengerStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            PassengerCountLabel.Text = $"Liczba pasa�er�w: {e.NewValue}";
        }





    }
}
