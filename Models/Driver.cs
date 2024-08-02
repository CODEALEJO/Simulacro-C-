using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacroC__AlejandroCastrillon.Models;
public class Driver : User
{
    public static List<Driver> drivers = new List<Driver>();
    public string? LicenseNumber { get; set; }
    public string? LicenseCategory { get; set; }
    public int DrivingExperiences { get; set; }



    public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string adreess, string lincenceNumber, string lincenceCategory, int drivingExperiences) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, adreess)
    {
        LicenseNumber = lincenceNumber;
        LicenseCategory = lincenceCategory;
        DrivingExperiences = drivingExperiences;
    }


    public static void UpdateLicenseCategory()
    {

    }
    public static void AddExperience()
    {

    }

    public static void AllCustomers()
    {
        foreach (var item in drivers)
        {
            item.GetInfoDrivers();
            Console.WriteLine("---------------------------------------------------");
        };
    }

    public void GetInfoDrivers()
    {
        Console.WriteLine($"\n ID: {Id}\n nombre: {Name}\n Apellido: {LastName}\n Tipo de documento: {TypeDocument}\n numero de documento: {IdentificationNumber}\n fecha de nacimeinto: {Birthdate}\n correo electronico: {Email}\n Telefono: {PhoneNumber}\n direccion: {Adreess}\n Numero de licencia {LicenseNumber}\n categoria del conductor: {LicenseCategory}\n años de experiencia: {DrivingExperiences}");
    }


    public static void ExperieceYears()
    {
        Console.WriteLine("Los conductores con más años de experiencia son: ");
        var exprienceDecending = drivers.OrderByDescending(drivers => drivers.DrivingExperiences).ToList();
        foreach (var item in exprienceDecending)
        {
            Console.WriteLine($"Nombre: {item.Name} Apellido: {item.LastName} Años de experiencia: {item.DrivingExperiences}");
        }
    }

    public static void categoryDriver()
    {
        Console.WriteLine("estos son los conductores con la categoria de A2: ");
        var CategoryATwo = drivers.Where(drivers => drivers.LicenseCategory == "A2").ToList();
        foreach (var item in CategoryATwo)
        {
            Console.WriteLine($"Nombre: {item.Name} Apellido: {item.LastName} Categoria: {item.LicenseCategory}");
        }
    }

}