using FluentValidation.Results;

namespace HypeHubLogic.Response;

public class BaseResponse<T>
{       
    public bool Success { get; set; }
    public T Data { get; set; }
    public string Message { get; set; }
    public List<string> ValidationErrors { get; set; }

    public BaseResponse()
    {
        ValidationErrors = new List<string>();
        Success = true;
    }

    public BaseResponse(T data, string message = null)
    {
        ValidationErrors = new List<string>();
        Success = true;
        Data = data;
        Message = message;
    }

    public BaseResponse(string message, bool success)
    {
        ValidationErrors = new List<string>();
        Success = success;
        Message = message;
    }

    public BaseResponse(ValidationResult validationResult)
    {
        ValidationErrors = new List<String>();
        Success = validationResult.Errors.Count < 0;
        foreach (var item in validationResult.Errors)
        {
            ValidationErrors.Add(item.ErrorMessage);
        }
    }
}
