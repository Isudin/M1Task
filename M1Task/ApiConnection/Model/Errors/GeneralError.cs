using System.Text;

namespace M1Task.ApiConnection.Model.Errors;

internal class GeneralError : IError
{
    public Error[] Errors { get; set; } = [];

    public string ErrorMessage
    {
        get
        {
            StringBuilder sb = new();
            foreach (var error in Errors)
                sb.Append(error.ErrorMessage);

            return sb.ToString();
        }
    }
}

internal class Error : IError
{
    public string Code { get; set; } = string.Empty;
    public string? Details { get; set; }
    public string Message { get; set; } = string.Empty;
    public string? Path { get; set; }
    public string UserMessage { get; set; } = string.Empty;

    public string ErrorMessage => $"[{Code}] {UserMessage}";
}
