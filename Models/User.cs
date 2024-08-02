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
//show datails person
    protected void ShowDetails()
    {
        Console.WriteLine($"\n nombre: {Name}\n Apellido: {LastName}\n Tipo de documento: {TypeDocument}\n numero de documento: {IdentificationNumber}\n fecha de nacimeinto: {Birthdate}\n correo electronico: {Email}\n Telefono: {PhoneNumber}\n direccion: {Adreess}");
    }
    public void GetDetailt()
    {
        ShowDetails();
    }
//calculate age 
    protected int CalculateAge()
    {
        if (!Birthdate.HasValue)
            return 0;

        DateOnly birthdate = Birthdate.Value;
        int age = DateTime.Today.Year - birthdate.Year;
        if (DateTime.Today < new DateTime(DateTime.Today.Year, birthdate.Month, birthdate.Day))
        {
            age--;
        }
        return age;
    }

    public void EncotrarUsuario(){
        Console.WriteLine("ingrese el nombre del usuario que desea encontrar ");
        string userName = Console.ReadLine();
        // User userFound = user.FirstOrDefault(user => user.Name == userName);
    }

    public void ShowAge()
    {
        CalculateAge();
    }

    public static void OverThirty()
    {

    }

}