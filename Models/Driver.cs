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


//constructor
    public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string adreess, string lincenceNumber, string lincenceCategory, int drivingExperiences) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, adreess)
    {
        LicenseNumber = lincenceNumber;
        LicenseCategory = lincenceCategory;
        DrivingExperiences = drivingExperiences;
    }



//method to update license information
    public static void UpdateLicenseCategory()
    {
        Console.WriteLine("Ingrese el nombre del conductor al que le quieras cambiar la categoria ");
        string driverName = Console.ReadLine();
        Driver driverToUpdate = drivers.FirstOrDefault(driver => driver.Name == driverName);
        if (driverToUpdate != null)
        {
            Console.WriteLine("Ingrese la nueva categoria");
            driverToUpdate.LicenseCategory = Console.ReadLine();
            Console.WriteLine($"La categoria del conductor {driverToUpdate.Name} {driverToUpdate.LastName} ha sido actualizada a {driverToUpdate.LicenseCategory}");
        }else{
            Console.WriteLine("El conductor no se encuentra en la lista");
        }

    }


//method to add experience
    public static void AddExperience()
    {
        Console.WriteLine("Ingres el nombre del conductor al que le quieras cambiar la categoria: ");
        string driverName = Console.ReadLine();
        Driver driverToUpdate = drivers.FirstOrDefault(driver => driver.Name == driverName);
        if (driverToUpdate != null)
        {
            Console.WriteLine($"ingrese los años experiencia de {driverName}: ");
            driverToUpdate.DrivingExperiences = int.Parse(Console.ReadLine());
            Console.WriteLine($"La experiencia del conductor {driverToUpdate.Name} {driverToUpdate.LastName} ha sido actualizada a {driverToUpdate.DrivingExperiences}");
        }else{
            Console.WriteLine("El conductor no se encuentra en la lista");
        }
    }


//method show all drivers
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

//method show experience information
    public static void ExperieceYears()
    {
        Console.WriteLine("Los conductores con más años de experiencia son: ");
        var exprienceDecending = drivers.OrderByDescending(drivers => drivers.DrivingExperiences).ToList();
        foreach (var item in exprienceDecending)
        {
            Console.WriteLine($"Nombre: {item.Name} Apellido: {item.LastName} Años de experiencia: {item.DrivingExperiences}");
        }
    }


//method show drivers with A2 category
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