namespace HypeHubDAL.Exeptions;

public class UnauthorizedRequestExeption : BaseException
{
    public UnauthorizedRequestExeption(string msg) : base(msg) { }
    public UnauthorizedRequestExeption(string msg, IEnumerable<string> errors) : base(msg, errors) { }
}
