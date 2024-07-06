using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Web;
using System.Net;
using M1Task.Domain.Model.Api;
using M1Task.Domain.Model.Api.Errors;

namespace M1Task.Application.Billings;

internal class BillingRequests(string orderId)
{
    private const string BaseAddress = "https://api.allegro.pl.allegrosandbox.pl/";
    private const string BillingEntriesRelativeUri = "billing/billing-entries";
    private readonly string _orderId = orderId;

    public IError? Error { get; private set; }

    internal async Task<BillingEntries?> GetBillingEntries()
    {
        HttpClient client = new()
        {
            Timeout = TimeSpan.FromSeconds(10),
            BaseAddress = new Uri(BaseAddress + BillingEntriesRelativeUri)
        };
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Authorization.Authorization.accessToken);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.allegro.public.v1+json"));

        string queryParameters = CreateQueryParameters();
        var response = await client.GetAsync($"?{queryParameters}");
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
        query["order.id"] = _orderId;

        return query.ToString()!;
    }
}
