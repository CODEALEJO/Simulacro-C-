using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacroC__AlejandroCastrillon.Models;
public class User
{
    protected Guid Id { get; set; }
    protected string? Name { get; set; }
    protected string? LastName { get; set; }
    protected string? TypeDocument { get; set; }
    protected string? IdentificationNumber { get; set; }
    protected DateOnly? Birthdate { get; set; }
    protected string? Email { get; set; }
    protected string? PhoneNumber { get; set; }
    protected string? Adreess { get; set; }



    protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly? birthdate, string email, string phoneNumber, string adreess)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        TypeDocument = typeDocument;
        IdentificationNumber = identificationNumber;
        Birthdate = birthdate;
        Email = email;
        PhoneNumber = phoneNumber;
        Adreess = adreess;

    }

    protected static void ShowDetails()
    {
    }
    protected static void CalculateAge()
    {

    }

    protected static void ShowAge()
    {

    }

    public static void OverThirty(){
       
    }

}