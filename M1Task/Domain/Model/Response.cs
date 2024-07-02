using M1Task.Domain.ApiConnection.Model.Errors;

namespace M1Task.Domain.Model
{
    internal class Response
    {
        public Response(string message, bool isError = false)
        {
            Message = message;
            IsError = isError;
        }

        public Response(IError error)
        {
            Message = error.ErrorMessage;
            IsError = true;
        }

        internal string Message { get; set; } = string.Empty;
        internal bool IsError { get; set; }
    }
}
