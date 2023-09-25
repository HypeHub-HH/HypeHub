namespace HypeHubDAL.Exeptions;

public class KeyNotFoundException : BaseException
{
    public KeyNotFoundException(string msg) : base(msg) { }
    public KeyNotFoundException(string msg, FluentValidation.Results.ValidationResult validationResult) : base(msg, validationResult) { }

}
