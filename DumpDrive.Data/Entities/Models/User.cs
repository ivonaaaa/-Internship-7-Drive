﻿using System;

public class User
{
    public Guid Id { get; private set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }

    public User(string email, string password, string username)
	{
        Id = Guid.NewGuid();
        Email = email;
        Password = password;
        Username = username;
    }
}
