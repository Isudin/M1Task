namespace M2Task.Domain.Model.Database
{
    public class Product
    {
        public int Id { get; set; }
        public LocalizedText Name { get; set; } = new();
        public LocalizedText Description { get; set; } = new();
        public string? PictureUrl { get; set; }
        public bool IsUseful { get; set; }
        public Price? Srp { get; set; }
        public string Ean { get; set; } = string.Empty;
        public List<int> VariantsIds { get; set; } = [];

        public class LocalizedText
        {
            public string Text { get; set; } = string.Empty;
            public string LanguageCode { get; set; } = "PL";
        }
        public class Price
        {
            public decimal Amount { get; set; }
            public string CurrencyCode { get; set; } = "PLN";
        }
    }
}
