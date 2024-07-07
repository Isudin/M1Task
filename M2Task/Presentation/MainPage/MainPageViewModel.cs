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

        List<Task<object?>> deserializationTasks = [];
        foreach (Type xmlModel in XmlModels)
            deserializationTasks.Add(DeserializeFile(xmlModel, reader));

        object?[] deserializedFiles = await Task.WhenAll(deserializationTasks);

        List<Task<Product?>> mappingResults = [];
        foreach (object? deserializedFile in deserializedFiles)
        {
            if (deserializedFile == null) continue;

            mappingResults.Add(MapDeserializedFile(deserializedFile));
        }

        Product?[] products = await Task.WhenAll(mappingResults);
        foreach (Product? product in products)
            if (product != null && !Products.Any(x => x.Ean == product.Ean || x.Name == product.Name))
                Products.Add(product);
    }

    private Task<object?> DeserializeFile(Type xmlModel, XmlNodeReader reader)
    {
        XmlSerializer serializer = new(xmlModel);
        if (!serializer.CanDeserialize(reader)) return Task.FromResult<object?>(null);

        return Task.FromResult(serializer.Deserialize(reader));
    }

    private Task<Product?> MapDeserializedFile(object deserializedFile)
    {
        //TODO Add file mapping
        return null;
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
