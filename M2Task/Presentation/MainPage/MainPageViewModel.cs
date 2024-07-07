using M2Task.Domain.Model.Database;
using M2Task.Domain.Model.XML;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Xml;
using System.Xml.Serialization;

namespace M2Task.Presentation;

public partial class MainPageViewModel
{
    public MainPageViewModel()
    {
        XmlModels = ListAllXmlModels();
    }

    public ICommand SelectFilesCommand => new Command(SelectFiles);

    private Type[] XmlModels { get; set; }
    public ObservableCollection<Product> Products { get; set; } = [];

    public void SelectFiles()
    {
        IEnumerable<FileResult> selectedFiles = Task.Run(async () => await FilePicker.Default.PickMultipleAsync()).Result;
        selectedFiles = selectedFiles.Where(x => x.ContentType == "text/xml");
        if (!selectedFiles.Any()) return;

        var t = ReadSelectedFiles(selectedFiles);
    }

    private async Task ReadSelectedFiles(IEnumerable<FileResult> files)
    {
        foreach (var file in files)
        {
            //if 
        }
    }

    private async Task ReadFile(FileResult file)
    {
        XmlDocument xml = new();
        xml.Load(file.OpenReadAsync().GetAwaiter().GetResult());
        var reader = new XmlNodeReader(xml);

        foreach (Type xmlModel in XmlModels)
        {
            object? deserializedFile = DeserializeFile(xmlModel, reader);
            if (deserializedFile == null) continue;

            MapDeserializedFile(xmlModel, deserializedFile);
        }
    }

    private async Task<object?> DeserializeFile(Type xmlModel, XmlNodeReader reader)
    {
        XmlSerializer serializer = new(xmlModel);
        if (!serializer.CanDeserialize(reader)) return null;

        return serializer.Deserialize(reader);
    }

    private async Task MapDeserializedFile(Type xmlModel, object deserializedFile)
    {

    }

    private Type[] ListAllXmlModels()
    {
        var type = typeof(IXmlModel);
        return AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(type.IsAssignableFrom)
            .ToArray();
    }
}
