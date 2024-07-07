using M2Task.Domain.Model.Database;
using M2Task.Domain.Model.XML;
using System.Globalization;

namespace M2Task.Domain.Model.Maps
{
    internal class D2Map : IMap<D2Products>
    {
        public static Product[] Map(D2Products xml)
        {
            if (xml.Products == null || xml.Products.Length == 0) return [];

            List<Product> products = [];
            foreach (var p in xml.Products)
            {
                Product product = new();
                product.Ean = p.Ean;
                product.Code = p.Sku;
                product.Names.Add(new(p.Name));
                product.Descriptions.Add(new(p.Desc));
                AddSrp(p, product);

                if (p.Photos != null)
                    foreach (var photo in p.Photos)
                        product.ImageUrls.Add(photo.Value);

                products.Add(product);
            }

            return products.ToArray();
        }

        private static void AddSrp(D2Products.ProductsProduct p, Product product)
        {
            decimal net = 0, gross = 0, vat = 0;
            _ = decimal.TryParse(p.PriceAfterDiscountNet, CultureInfo.InvariantCulture, out net);
            _ = decimal.TryParse(p.RetailPriceGross, CultureInfo.InvariantCulture, out gross);
            _ = decimal.TryParse(p.Vat, CultureInfo.InvariantCulture, out vat);
            product.Srp = new(net, gross, vat);
        }
    }
}
