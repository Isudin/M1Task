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
                product.Quantity = p.Qty;
                AddSrp(p, product);

                if (p.Photos != null)
                    foreach (var photo in p.Photos)
                        product.ImageUrls.Add(photo.Value);

                if (!string.IsNullOrEmpty(p.Name))
                    product.Names.Add(new(p.Name));

                if (!string.IsNullOrEmpty(p.Desc))
                    product.Descriptions.Add(new(p.Desc));

                products.Add(product);
            }

            return products.ToArray();
        }

        private static void AddSrp(D2Products.ProductsProduct p, Product product)
        {
            _ = decimal.TryParse(p.PriceAfterDiscountNet, CultureInfo.InvariantCulture, out decimal net);
            _ = decimal.TryParse(p.RetailPriceGross, CultureInfo.InvariantCulture, out decimal gross);
            _ = decimal.TryParse(p.Vat, CultureInfo.InvariantCulture, out decimal vat);
            product.Srp = new(net, gross, vat);
        }
    }
}
