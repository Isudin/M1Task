using M2Task.Domain.Model.Database;
using M2Task.Domain.Model.XML;

namespace M2Task.Domain.Model.Maps
{
    internal class D1M2Map : IMap<D1M2Offer>
    {
        public static Product[] Map(D1M2Offer xml)
        {
            if (xml.Products == null) return [];

            List<Product> products = [];
            foreach (var p in xml.Products.Products)
            {
                Product product = new();
                product.Code = p.Id.ToString();
                var srp = p.Srp;
                product.Srp = new Product.Price(srp.Net, srp.Gross, srp.Vat, p.Currency);
                AddNames(p, product);
                AddDescriptions(p, product);
                AddCodes(p, product);

                foreach(var image in p.Images.Originals)
                    product.ImageUrls.Add(image.Url);

                products.Add(product);
            }

            return products.ToArray();
        }

        private static void AddNames(D1M2Offer.OfferProductsProduct p, Product product)
        {
            foreach (var name in p.Description.Name)
            {
                if (product.Names.Any(x => x.LanguageCode == name.Lang)) continue;

                product.Names.Add(new(name.Value, name.Lang));
            }
        }

        private static void AddDescriptions(D1M2Offer.OfferProductsProduct p, Product product)
        {
            foreach (var desc in p.Description.ShortDesc)
            {
                if (product.Descriptions.Any(x => x.LanguageCode == desc.Lang)) continue;

                product.Descriptions.Add(new(desc.Value, desc.Lang));
            }
        }

        private static void AddCodes(D1M2Offer.OfferProductsProduct p, Product product)
        {
            for (int i = 0; i < p.Sizes.Sizes.Length; i++)
            {
                var size = p.Sizes.Sizes[i]!;
                if (i == 0)
                {
                    product.Ean = size.CodeProducer;
                    product.Code = size.Code;
                }
                else
                    product.VariantsCodes.Add(size.Code);
            }
        }
    }
}
