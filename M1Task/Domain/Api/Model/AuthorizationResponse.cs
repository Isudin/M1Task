using Newtonsoft.Json;

namespace M1Task.Domain.Api.Model;

internal class AuthorizationResponse
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }

    [JsonProperty("token_type")]
    public string TokenType { get; set; }

    [JsonProperty("expires_in")]
    public string ExpiresIn { get; set; }

    [JsonProperty("scope")]
    public string Scope { get; set; }

    [JsonProperty("allegro_api")]
    public string AllegroApi { get; set; }

    [JsonProperty("jti")]
    public string JTI { get; set; }
}
