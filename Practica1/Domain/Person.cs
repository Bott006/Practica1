using System;

namespace Practica1.Domain
{
    public record Person(int Id, string FirstName, string LastName, string Email, char Gender, string Job, int Age);
}