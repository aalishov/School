using System;

public class InvalidNameException : Exception
{
    public InvalidNameException() : base("Invalid name!") { }
}

public class InvalidAgeException : Exception
{
    public InvalidAgeException() : base("Invalid age!") { }

    public InvalidAgeException(string message) : base(message) { }
}


