namespace HypeHubDAL.Exeptions;

public class NotImplementedException : BaseException
{
    public NotImplementedException(string msg) : base(msg) { }
    public NotImplementedException(string msg, FluentValidation.Results.ValidationResult validationResult) : base(msg, validationResult) { }
}
