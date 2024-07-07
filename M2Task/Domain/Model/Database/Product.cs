namespace M2Task.Domain.Model.Database
{
    public class Product
    {
        public int Id { get; set; }
        public LocalizedText? Name { get; set; }
        public LocalizedText? Description { get; set; }
        public string? PictureUrl { get; set; }
        public bool IsUseful { get; set; }
        public Price? Srp { get; set; }
        public string Ean { get; set; } = string.Empty;
        public List<int> VariantsIds { get; set; } = [];

        public record LocalizedText(decimal Text, string LanguageCode = "PLN") { }

        public record Price(decimal Net, decimal Gross, decimal Vat, string CurrencyCode = "PLN") { }
    }
}
