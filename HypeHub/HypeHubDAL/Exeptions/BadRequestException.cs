﻿namespace HypeHubDAL.Exeptions;

public class BadRequestException : Exception
{
    public BadRequestException(string msg) : base(msg) { }
}