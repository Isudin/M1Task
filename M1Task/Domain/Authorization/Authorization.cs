using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;
using System.Web;
using M1Task.Domain.Model;
using System.Text;
using System.Diagnostics;
using M1Task.Domain.Model.Api;

namespace M1Task.Domain.Authorization
{
    internal class Authorization
    {
        private const string BaseAddress = "https://allegro.pl.allegrosandbox.pl/";
        private const string DeviceRelativeUri = "auth/oauth/device";
        private const string TokenRelativeUri = "auth/oauth/token";

        internal static string accessToken = string.Empty;
        internal static string refreshToken = string.Empty;

        internal async Task<Response> Authorize()
        {
            HttpClient client = new()
            {
                Timeout = TimeSpan.FromSeconds(10),
                BaseAddress = new Uri(BaseAddress + DeviceRelativeUri)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var plainTextBytes = Encoding.UTF8.GetBytes($"{config["ClientId"]}:{config["ClientSecret"]}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(plainTextBytes));

            var uriParams = new Dictionary<string, string>() { { "client_id", config["ClientId"] } };
            var uri = new Uri($"{BaseAddress}{DeviceRelativeUri}");
            var response = await client.PostAsync(uri, new FormUrlEncodedContent(uriParams));
            if (response.StatusCode == HttpStatusCode.OK)
                return await AuthorizeUser(client, response);

            return new Response($"Could not authorize device. Status code: {(int)response.StatusCode} - {response.StatusCode}",
                true);
        }

        private static async Task<Response> AuthorizeUser(HttpClient client, HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            DeviceAuthorization authorizationResponse = JsonConvert.DeserializeObject<DeviceAuthorization>(content)!;

            var url = authorizationResponse.VerificationUriComplete.ToString();
            url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            var uriAuth = $"{BaseAddress}{TokenRelativeUri}?grant_type=urn%3Aietf%3Aparams%3Aoauth%3Agrant-type%3Adevice_code&device_code={authorizationResponse.DeviceCode}";

            var counter = 0;
            while (counter < 24)
            {
                var responseAuthorization = await client.PostAsync(uriAuth, null);

                if (responseAuthorization.StatusCode == HttpStatusCode.OK)
                {
                    var authContent = await responseAuthorization.Content.ReadAsStringAsync();

                    var authorizationAllegro = JsonConvert.DeserializeObject<UserAuthorization>(authContent)!;
                    accessToken = authorizationAllegro.AccessToken;
                    refreshToken = authorizationAllegro.RefreshToken;

                    return new Response("Successfully authorized");
                }

                Thread.Sleep(5000);
                counter++;
            }

            return new Response($"Could not authorize device. Status code: " +
                $"{(int)response.StatusCode} - {response.StatusCode}", true);
        }
    }
}
