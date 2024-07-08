using M2Task.Domain;
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
    public ICommand SendWaresToDatabaseCommand => new Command(SendWaresToDatabase);

    private Type[] XmlModels { get; set; }
    public ObservableCollection<Product> Products { get; set; } = [];

    public void SelectFiles()
    {
        IEnumerable<FileResult> selectedFiles = Task.Run(async () => await FilePicker.Default.PickMultipleAsync()).Result;
        selectedFiles = selectedFiles.Where(x => x.ContentType == "text/xml");
        if (!selectedFiles.Any()) return;

        Task.Run(async () => await ReadSelectedFiles(selectedFiles));
    }

    public void SendWaresToDatabase()
    {
        var selectedWares = Products.Count(x => x.SendToDatabase);
        string message = $"Successfully sent {selectedWares} to database.*{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}" +
            $"*No data has been sent. This application is just a proof of concept and is not supposed to send further any data.";

        Application.Current!.MainPage!.DisplayAlert("Success", message, "OK").GetAwaiter().GetResult();
    }

    private async Task ReadSelectedFiles(IEnumerable<FileResult> files)
    {
        List<Task> tasks = [];
        foreach (var file in files)
            tasks.Add(ReadFile(file));

        await Task.WhenAll(tasks);
    }

    private async Task ReadFile(FileResult file)
    {
        List<Task<object?>> deserializationTasks = [];
        foreach (Type xmlModel in XmlModels)
            deserializationTasks.Add(DeserializeFile(xmlModel, file));

        object?[] deserializedFiles = await Task.WhenAll(deserializationTasks.Where(x => x != null));

        List<Task<Product[]>> mappingResults = [];
        foreach (object? deserializedFile in deserializedFiles)
        {
            if (deserializedFile == null) continue;

            mappingResults.Add(MapDeserializedFile(deserializedFile));
        }

        Product[][] products = await Task.WhenAll(mappingResults);
        foreach (Product[] pProducts in products)
            foreach (Product product in pProducts)
                if (product != null && !Products.Any(x => x.Ean == product.Ean || x.Names == product.Names))
                    Products.Add(product);
    }

    private Task<object?> DeserializeFile(Type xmlModel, FileResult file)
    {
        var stream = file.OpenReadAsync().GetAwaiter().GetResult();
        var reader = XmlReader.Create(stream);
        XmlSerializer serializer = new(xmlModel);
        if (!serializer.CanDeserialize(reader)) return Task.FromResult<object?>(null);

        stream.Position = 0;
        try
        {
            return Task.FromResult(serializer.Deserialize(stream));
        }
        catch
        {
            return null!;
        }
    }

    private async Task<Product[]> MapDeserializedFile(object deserializedFile)
    {
        try
        {
            return await Task.Run(() => XmlMapper.MapToProducts((IXmlModel)deserializedFile));
        }
        catch
        {
            return [];
        }
    }

    private Type[] ListAllXmlModels()
    {
        var type = typeof(IXmlModel);
        return AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(x => type.IsAssignableFrom(x) && x.Name != type.Name)
            .ToArray();
    }
}
