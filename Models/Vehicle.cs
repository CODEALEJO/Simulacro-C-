using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacroC__AlejandroCastrillon.Models;
public class Vehicle
{
    public static List<Vehicle> vehicles = new List<Vehicle>();
    public int Id { get; set; }
    public string? LicensePlate { get; set; }
    public string? Tipe { get; set; }
    public string? EngineNumber { get; set; }
    public string? SerialNumber { get; set; }
    public byte PeopleCapacity { get; set; }
    public Driver? Owner { get; set; }

    public Vehicle(int id, string licensePlate, string tipe, string engineNumber, string serialNumber, Byte peopleCapacity, Driver? owner)
    {
        Id = id;
        LicensePlate = licensePlate;
        Tipe = tipe;
        EngineNumber = engineNumber;
        SerialNumber = SerialNumber;
        PeopleCapacity = peopleCapacity;
        Owner = owner;
    }
    public static void DeleteVehicle()
    {

    }
}