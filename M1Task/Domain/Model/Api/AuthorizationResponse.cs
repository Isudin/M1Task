using Newtonsoft.Json;

namespace M1Task.Domain.Model.Api;

internal class UserAuthorization
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }
    [JsonProperty("refresh_token")]
    public string RefreshToken { get; set; }

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


[JsonObject(MemberSerialization.OptOut)]
public class DeviceAuthorization
{
    [JsonProperty("device_code")]
    public string DeviceCode { get; set; }
    [JsonProperty("expires_in")]
    public string ExpiresIn { get; set; }
    [JsonProperty("interval")]
    public int interval { get; set; } = 5;
    [JsonProperty("verification_uri")]
    public Uri VerificationUri { get; set; }
    [JsonProperty("verification_uri_complete")]
    public Uri VerificationUriComplete { get; set; }
    [JsonProperty("user_code")]
    public string UserCode { get; set; }
}