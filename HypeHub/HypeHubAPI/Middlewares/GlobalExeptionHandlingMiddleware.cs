using HypeHubDAL.Exeptions;
using System.Net;
using System.Text.Json;

namespace HypeHubAPI.Middlewares;

public class GlobalExeptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public GlobalExeptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (BaseException ex)
        {
            await HandleExeptionAsync(context, ex);
        }
    }

    private static Task HandleExeptionAsync(HttpContext context, BaseException ex)
    {
        HttpStatusCode status;
        var stackTrace = string.Empty;
        string message = "";
        List<string> errors = new();

        var exeptionType = ex.GetType();

        if (exeptionType == typeof(NotFoundException))
        {
            message = ex.Message;
            status = HttpStatusCode.NotFound;
            stackTrace = ex.StackTrace;
        }
        else if (exeptionType == typeof(ValidationFailedException))
        {
            message = ex.Message;
            status = HttpStatusCode.BadRequest;
            errors = ex.Errors;
            stackTrace = ex.StackTrace;
        }
        else if (exeptionType == typeof(WrongCredentialsException))
        {
            message = ex.Message;
            status = HttpStatusCode.Unauthorized;
            errors = ex.Errors;
            stackTrace = ex.StackTrace;
        }
        else if (exeptionType == typeof(BadRequestException))
        {
            message = ex.Message;
            status = HttpStatusCode.BadRequest;
            errors = ex.Errors;
            stackTrace = ex.StackTrace;
        }
        else if (exeptionType == typeof(UnauthorizedAccessException))
        {
            message = ex.Message;
            status = HttpStatusCode.BadRequest;
            errors = ex.Errors;
            stackTrace = ex.StackTrace;
        }
        else
        {
            message = ex.Message;
            status = HttpStatusCode.InternalServerError;
            stackTrace = ex.StackTrace;
        }

        var exeptionResult = JsonSerializer.Serialize(new { message = message, status = status, errors = errors });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)status;

        return context.Response.WriteAsync(exeptionResult);
    }
}
