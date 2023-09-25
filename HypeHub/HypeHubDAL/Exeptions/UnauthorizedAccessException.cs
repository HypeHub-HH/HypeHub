namespace HypeHubDAL.Exeptions;

public class UnauthorizedAccessException : BaseException
{
    public UnauthorizedAccessException(string msg) : base(msg) { }
    public UnauthorizedAccessException(string msg, FluentValidation.Results.ValidationResult validationResult) : base(msg, validationResult) { }
}
