namespace HypeHubDAL.Exeptions;

public class NotFoundException : BaseException
{
    public NotFoundException(string msg) : base(msg) { }
    public NotFoundException(string msg, FluentValidation.Results.ValidationResult validationResult) : base(msg, validationResult) { }
}
