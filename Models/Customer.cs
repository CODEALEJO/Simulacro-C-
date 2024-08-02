using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace simulacroC__AlejandroCastrillon.Models;
public class Customer : User
{
    public static List<Customer> customers = new List<Customer>();
    public string? MemberShipLevel { get; set; }
    public string? PreferredPaymenMethod { get; set; }

    public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly? birthdate, string email, string phoneNumber, string adreess, string memberShipLevel, string preferredPaymenMethod) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, adreess)
    {
        MemberShipLevel = memberShipLevel;
        PreferredPaymenMethod = preferredPaymenMethod;
    }

    public void UpdateMemberShipLevel()
    {

    }

    public static void AllCustomers()
    {
        foreach (var item in customers)
        {
            item.GetInfoCustomers();
            Console.WriteLine("---------------------------------------------------");
        };
    }

    public void GetInfoCustomers()
    {
        Console.WriteLine($"\n ID: {Id}\n nombre: {Name}\n Apellido: {LastName}\n Tipo de documento: {TypeDocument}\n numero de documento: {IdentificationNumber}\n fecha de nacimeinto: {Birthdate}\n correo electronico: {Email}\n Telefono: {PhoneNumber}\n direccion: {Adreess}\n Tipo de membresia {MemberShipLevel}\n metodo de pago: {PreferredPaymenMethod}");
    }

    public static void CreditCardCustomers()
    {
        Console.WriteLine("Los clientes con tarjeta de credito son: ");
        customers.Where(customers => customers.PreferredPaymenMethod == "Tarjeta de credito").ToList().ForEach(customer => customer.GetInfoCustomers());
    }


}