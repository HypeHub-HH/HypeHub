using FluentValidation.Results;

namespace HypeHubLogic.Response;

public class BaseResponse
{
    public bool IsSuccess { get; private set; }
    public string? Message { get; private set; }
    public List<string> Errors { get; private set; }

    private BaseResponse(bool isSuccess, string message, List<string> errors)
    {
        IsSuccess = isSuccess;
        Message = message;
        Errors = errors;
    }

    public static BaseResponse Success(string message = null)
    {
        return new BaseResponse(true, message, null);
    }

    public static BaseResponse Failure(string message, List<string> errors = null)
    {
        return new BaseResponse(false, message, errors);
    }

    public static BaseResponse Failure(List<string> errors)
    {
        return new BaseResponse(false, null, errors);
    }
}
