using System.Numerics;
using System.Xml.Serialization;
using PolymorphismExample.Lib;


public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        DateOfBirth = dateOfBirth;
    }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = "";
        DateOfBirth = dateOfBirth;
    }
    public int GetAge()
    {
        var today = DateTime.Today;
        int age = today.Year - DateOfBirth.Year;
        if (DateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    public bool IsValidAge()
    {
        int age = GetAge();
        return age >= 0 && age <= 130;
    }
}