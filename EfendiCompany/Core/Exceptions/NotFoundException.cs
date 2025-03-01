﻿namespace Core.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(Type type, Guid id) : base($"{type.Name} not found with Id : {id}")
    {

    }

    public NotFoundException(Type type, string message) : base($"{type.Name} not found with : {message}")
    {

    }

}
