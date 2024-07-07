using M2Task.Domain.Model.XML;
using M2Task.Presentation;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace M2Task;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var result = Task.Run(async () => await FilePicker.Default.PickAsync()).Result;

        XmlDocument xml = new();
        xml.Load(result.OpenReadAsync().GetAwaiter().GetResult());
        var reader = new XmlNodeReader(xml);

        XmlSerializer serializer = new(typeof(D3Produkty));
        var can = serializer.CanDeserialize(reader);
        serializer.Deserialize(reader);

        var t = 0;
    }
}
