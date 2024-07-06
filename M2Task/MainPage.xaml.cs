using M2Task.Presentation;

namespace M2Task;

public partial class MainPage : ContentPage
{
    private readonly MainPageViewModel _viewModel;
    public MainPage(MainPageViewModel viewModel)
    {
        _viewModel = viewModel;
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {


    }
}
