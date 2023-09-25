namespace HypeHubDAL.Exeptions;

public class BadRequestException : BaseException
{
    public BadRequestException(string msg) : base(msg) { }
    public BadRequestException(string msg, FluentValidation.Results.ValidationResult validationResult) : base(msg, validationResult) { }
}
