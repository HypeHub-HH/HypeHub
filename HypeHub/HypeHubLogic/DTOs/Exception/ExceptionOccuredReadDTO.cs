using System.Net;

namespace HypeHubLogic.DTOs.Exception;
public record ExceptionOccuredReadDTO
{
    public string Msg { get; set; }
    public IEnumerable<string> Errors { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public ExceptionOccuredReadDTO(string msg, IEnumerable<string> errors, HttpStatusCode statusCode)
    {
        Msg = msg;
        Errors = errors;
        StatusCode = statusCode;
    }
}

