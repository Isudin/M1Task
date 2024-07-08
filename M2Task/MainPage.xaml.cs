using M2Task.Presentation;

namespace M2Task;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    private async void OnSendWaresClicked(object sender, EventArgs e)
    {
        string message = $"Successfully sent wares to database.*{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}" +
            $"*No data has been sent. This application is just a proof of concept and is not supposed to send further any data.";

        await DisplayAlert("Success", message, "OK");
    }
}
