namespace M2Task.Domain.Model.Database
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Ean { get; set; } = string.Empty;
        public List<LocalizedText> Names { get; set; } = [];
        public List<LocalizedText> Descriptions { get; set; } = [];
        public List<string> ImageUrls { get; set; }
        public bool IsUseful { get; set; }
        public Price? Srp { get; set; }
        public List<string> VariantsCodes { get; set; } = [];

        public record LocalizedText(string Text, string LanguageCode = "PL") { }

        public record Price(decimal Net, decimal Gross, decimal Vat, string CurrencyCode = "PLN") { }
    }
}
