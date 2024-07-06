using M2Task.Presentation;
using System.Diagnostics;

namespace M2Task;

public partial class MainPage : ContentPage
{
    private readonly MainPageViewModel _viewModel;
    public MainPage(MainPageViewModel viewModel)
    {
        _viewModel = viewModel;
        //InitializeComponent();
    }

    public MainPage()
    {

        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {

        var result = FilePicker.Default.PickAsync().GetAwaiter().GetResult();

        var file = 0;
    }
}
