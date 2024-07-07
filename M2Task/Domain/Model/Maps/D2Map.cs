using M2Task.Domain.Model.Database;
using M2Task.Domain.Model.XML;

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
                product.Srp = new(p.PriceAfterDiscountNet, p.RetailPriceGross, p.Vat);

                foreach (var photo in p.Photos)
                    product.ImageUrls.Add(photo.Value);

                products.Add(product);
            }

            return products.ToArray();
        }
    }
}
