﻿using HypeHubLogic.DTOs.AccountCredentials;

namespace HypeHubLogic.DTOs.Account;

public class AccountCreateDTO
{
    public AccountCredentialsCreateDTO Credentials { get; init; }
    public string Username { get; init; }
    public bool IsPrivate { get; init; }
    public string? AvatarUrl { get; init; }
}