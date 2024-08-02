using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacroC__AlejandroCastrillon.Models;
public class Driver : User
{
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
}