using M2Task.Domain.Model.Database;
using M2Task.Domain.Model.Maps;
using M2Task.Domain.Model.XML;

namespace M2Task.Domain
{
    internal class XmlMapper
    {
        public static Product[] MapToProducts(IXmlModel xml)
        {

            try
            {
                //TODO: Automate mapping
                if (xml is D1M1Offer d1m1)
                    return D1M1Map.Map(d1m1);

                if (xml is D1M2Offer d1m2)
                    return D1M2Map.Map(d1m2);

                if (xml is D2Products d2)
                    return D2Map.Map(d2);

                if (xml is D3Produkty d3)
                    return D3Map.Map(d3);
            }
            catch { }

            return [];
        }
    }
}
