using M2Task.Domain.Model.Database;
using M2Task.Domain.Model.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Task.Domain.Model.Maps
{
    internal class D3Map : IMap<D3Produkty>
    {
        public static Product[] Map(D3Produkty xml)
        {
            if (xml.Produkty == null || xml.Produkty.Length == 0) return [];

            List<Product> products = [];
            foreach (var p in xml.Produkty)
            {
                Product product = new();
                product.Ean = p.Ean;
                product.Code = p.Kod;
                product.Names.Add(new(p.NazwaPl));
                product.Names.Add(new(p.NazwaEn, "EN"));
                product.Descriptions.Add(new(p.DlugiOpisPl));
                product.Descriptions.Add(new(p.DlugiOpisEn, "EN"));
                AddSrp(p, product);
                foreach (var image in p.Zdjecia.Zdjecia)
                    product.ImageUrls.Add(image.Url);

                products.Add(product);
            }

            return products.ToArray();
        }

        private static void AddSrp(D3Produkty.ProduktyProdukt p, Product product)
        {
            bool hasPrice = decimal.TryParse(p.CenaSugerowana, out decimal gross);
            bool hasVat = decimal.TryParse(p.Vat, out decimal vat);
            if (hasPrice)
            {
                if (hasVat)
                {
                    decimal net = Math.Round(gross * (100 - vat), 2);
                    product.Srp = new(net, gross, vat);
                }
                else
                    product.Srp = new(0, gross, 0);
            }
        }
    }
}
