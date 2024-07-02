using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;
using System.Web;
using M1Task.Domain.Api.Model;
using M1Task.Domain.Model;
using System.Text;

namespace M1Task.Domain.Authorization
{
    internal class Authorization
    {
        private const string BaseAddress = "https://allegro.pl/";
        private const string AuthorizationRelativeUri = "auth/oauth/token";

        internal static string accessToken = string.Empty;
        internal static string refreshToken = string.Empty;

        internal async Task<Response> Authorize()
        {
            HttpClient client = new()
            {
                Timeout = TimeSpan.FromSeconds(10),
                BaseAddress = new Uri(BaseAddress + AuthorizationRelativeUri)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string queryParameters = CreateQueryParameters();
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var plainTextBytes = Encoding.UTF8.GetBytes($"{config["ClientId"]}:{config["ClientSecret"]}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(plainTextBytes));

            var response = await client.GetAsync($"?{queryParameters}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                AuthorizationResponse authorizationResponse = JsonConvert.DeserializeObject<AuthorizationResponse>(content)!;
                accessToken = authorizationResponse.AccessToken;
                return new Response("Successfully authorized");
            }

            return new Response($"Could not authorize device. Status code: {(int)response.StatusCode} - {response.StatusCode}");
            //switch (response.StatusCode)
            //{
            //    case HttpStatusCode.OK:
            //        return JsonConvert.DeserializeObject<BillingEntries>(content);
            //    case HttpStatusCode.Unauthorized:
            //        Error = JsonConvert.DeserializeObject<AuthorizationError>(content);
            //        break;
            //    case HttpStatusCode.NotAcceptable:
            //        Error = JsonConvert.DeserializeObject<GeneralError>(content);
            //        break;
            //}

            //return null;
        }

        private string CreateQueryParameters()
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["grant_type"] = "client_credentials";

            //query["response_type"] = "code";
            //query["client_id"] = config["ClientId"];
            //query["redirect_uri"] = config["RedirectUri"];
            //query["prompt"] = "";

            return query.ToString()!;
        }
    }
}
