﻿namespace M1Task.Model.Errors;

internal class AuthorizationError : IError
{
    public string Error { get; set; } = string.Empty;
    public string ErrorDescription { get; set; } = string.Empty;

    public string ErrorMessage => $"[{Error}] {ErrorDescription}";
}
