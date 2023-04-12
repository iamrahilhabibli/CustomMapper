﻿namespace ConsoleApp.Entities;

public class Customer : IEntity
{
    public int Id { get; set ; }
    public string? Name { get; set ; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }

}
