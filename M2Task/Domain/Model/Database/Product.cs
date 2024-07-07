namespace M2Task.Domain.Model.Database
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Ean { get; set; } = string.Empty;
        public LocalizedText Name
        {
            get
            {
                if (Names.Count == 0) return new("Brak nazwy");

                string[] plCode = ["PL", "POL"];
                var namePl = Names.FirstOrDefault(x => plCode.Contains(x.LanguageCode.ToUpper()));
                if (namePl != null)
                    return namePl;

                return Names.First();
            }
        }

        public LocalizedText Description
        {
            get
            {
                if (Descriptions.Count == 0) return new("Brak opisu");

                string[] plCode = ["PL", "POL"];
                var descPl = Descriptions.FirstOrDefault(x => plCode.Contains(x.LanguageCode.ToUpper()));
                if (descPl != null)
                    return descPl;

                return Descriptions.First();
            }
        }

        public List<LocalizedText> Names { get; set; } = [];
        public List<LocalizedText> Descriptions { get; set; } = [];
        public List<string> ImageUrls { get; set; } = [];
        public string? Icon => ImageUrls?.FirstOrDefault();
        public Price? Srp { get; set; }
        public string GrossWithCurrency
        {
            get
            {
                if (Srp == null || Srp.Gross == 0) return "Brak danych";

                return $"{Srp.Gross} {Srp.CurrencyCode}";
            }
        }

        public List<string> VariantsCodes { get; set; } = [];
        public decimal Quantity { get; set; }
        public string QuantityStr => Quantity > 0 ? "Brak danych" : Quantity.ToString();
        public bool IsUseful { get; set; }

        public record LocalizedText(string Text, string LanguageCode = "PL") { }

        public record Price(decimal Net, decimal Gross, decimal Vat, string CurrencyCode = "PLN") { }
    }
}
