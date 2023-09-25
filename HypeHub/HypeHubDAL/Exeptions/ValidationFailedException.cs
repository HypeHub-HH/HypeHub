using System.ComponentModel.DataAnnotations;
using FluentValidation;
using FluentValidation.Results;

namespace HypeHubDAL.Exeptions;

public class ValidationFailedException : BaseException
{
    public ValidationFailedException(string msg) : base(msg) { }
    public ValidationFailedException(string msg, FluentValidation.Results.ValidationResult validationResult) : base(msg, validationResult)
    {
        foreach (var item in validationResult.Errors)
        {
            msg += item;
        }
    }
}
