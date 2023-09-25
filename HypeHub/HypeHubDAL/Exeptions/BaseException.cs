namespace HypeHubDAL.Exeptions;

public class BaseException : Exception
{
    public List<string> Errors { get; set; } = new();

    public BaseException(string msg) : base(msg)
    {
    }

    public BaseException(string msg, FluentValidation.Results.ValidationResult validationResult) : base(msg)
    {
        foreach (var item in validationResult.Errors)
        {
            Errors.Add(item.ErrorMessage);
        }
    }
}
