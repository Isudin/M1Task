using M2Task.Domain.Model.Database;
using M2Task.Domain.Model.XML;

namespace M2Task.Domain.Model.Maps
{
    internal interface IMap<T> where T : IXmlModel
    {
        abstract static Product[] Map(T xml);
    }
}
