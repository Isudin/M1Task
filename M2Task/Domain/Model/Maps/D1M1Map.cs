using M2Task.Domain.Model.Database;
using M2Task.Domain.Model.XML;

namespace M2Task.Domain.Model.Maps
{
    internal class D1M1Map : IMap<D1M1Offer>
    {
        public static Product[] Map(D1M1Offer xml)
        {
            if (xml.Products == null) return [];

            var currency = xml.Products.Currency;
            List<Product> products = [];
            foreach (var p in xml.Products.Products)
            {
                if (p.Sizes == null || p.Sizes.Sizes == null || p.Sizes.Sizes.Length == 0) continue;

                Product product = new();
                var srp = p.Srp;
                product.Srp = new Product.Price(srp.Net, srp.Gross, srp.Vat, currency);

                for (int i = 0; i < p.Sizes.Sizes.Length; i++)
                {
                    var size = p.Sizes.Sizes[i]!;
                    if (i==0)
                    {
                        product.Ean = size.CodeProducer;
                        product.Code = size.Code;
                        product.Quantity = size.Stock.Quantity;
                    }
                    else
                        product.VariantsCodes.Add(size.Code);
                }

                products.Add(product);
            }

            return products.ToArray();
        }
    }
}
