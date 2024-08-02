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
    public  static Driver? Owner { get; set; }


//constructor 
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

    //method to Delete Vehicle
    public static void DeleteVehicle()
    {
        Console.WriteLine("Ingrese el Id del auto que desea eliminar: ");
        int id = int.Parse(Console.ReadLine());
        Vehicle vehicleToDelete = vehicles.FirstOrDefault(vehicle => vehicle.Id == id);
        if (vehicleToDelete!= null)
        {
            vehicles.Remove(vehicleToDelete);
            Console.WriteLine("El auto ha sido eliminado correctamente");
        }else{
            Console.WriteLine("El auto no se encuentra en la lista");
        }
    }

//method to get all vechicles 
        public static void AllVehicles()
    {
        foreach (var item in vehicles)
        {
            item.GetInfoVehicles();
            Console.WriteLine("---------------------------------------------------");
        };
    }

    public void GetInfoVehicles()
    {
        Console.WriteLine($"\n ID: {Id}\n placa: {LicensePlate}\n tipo de transporte: {Tipe}\n Numero del motor: {EngineNumber}\n Numero de serie: {SerialNumber}\n capacidad del vehiculo: {PeopleCapacity}");
    }
}