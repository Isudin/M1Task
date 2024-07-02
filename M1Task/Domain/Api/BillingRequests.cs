using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Web;
using System.Net;
using M1Task.Domain.ApiConnection.Model;
using M1Task.Domain.ApiConnection.Model.Errors;

namespace M1Task.Domain.ApiConnection;

internal class BillingRequests(string orderId)
{
    //internal BillingRequests(string marketPlaceId, DateTime occuredAtFrom, DateTime occuredAtTo, string[] typeIds,
    //                   string offerId, string orderId, int limit, int offset)
    //{
    //    _marketPlaceId = marketPlaceId;
    //    _occuredAtFrom = occuredAtFrom;
    //    _occuredAtTo = occuredAtTo;
    //    _typeIds = typeIds;
    //    _offerId = offerId;
    //    _orderId = orderId;
    //    _limit = limit;
    //    _offset = offset;
    //}

    private const string BaseAddress = "https://apps.developer.allegro.pl.allegrosandbox.pl/";
    private const string BillingEntriesRelativeUri = "billing/billing-entries/";
    //private readonly string _marketPlaceId = marketPlaceId;
    //private readonly DateTime _occuredAtFrom = occuredAtFrom;
    //private readonly DateTime _occuredAtTo = occuredAtTo;
    //private readonly string[] _typeIds = typeIds;
    //private readonly string _offerId = offerId;
    private readonly string _orderId = orderId;
    //private readonly int _limit = limit;
    //private readonly int _offset = offset;

    public IError? Error { get; private set; }

    internal async Task<BillingEntries?> GetBillingEntries()
    {
        HttpClient client = new()
        {
            Timeout = TimeSpan.FromSeconds(10),
            BaseAddress = new Uri(BaseAddress + BillingEntriesRelativeUri)
        };
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string queryParameters = CreateQueryParameters();
        var response = await client.GetAsync($"{queryParameters}");
        var content = await response.Content.ReadAsStringAsync();
        switch (response.StatusCode)
        {
            case HttpStatusCode.OK:
                return JsonConvert.DeserializeObject<BillingEntries>(content);
            case HttpStatusCode.Unauthorized:
                Error = JsonConvert.DeserializeObject<AuthorizationError>(content);
                break;
            case HttpStatusCode.NotAcceptable:
                Error = JsonConvert.DeserializeObject<GeneralError>(content);
                break;
        }

        return null;
    }

    private string CreateQueryParameters()
    {
        var query = HttpUtility.ParseQueryString(string.Empty);
        //query["marketplaceId"] = _marketPlaceId;
        //query["occurredAt.gte"] = JsonConvert.SerializeObject(_occuredAtFrom);
        //query["occurredAt.lte"] = JsonConvert.SerializeObject(_occuredAtTo);
        //foreach (var typeId in _typeIds)
        //    query["type.id"] = typeId;

        //query["type.id"] = _offerId;
        query["order.id"] = _orderId;
        //query["limit"] = _limit.ToString();
        //query["offset"] = _offset.ToString();

        return query.ToString()!;
    }
}
