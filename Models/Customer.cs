using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacroC__AlejandroCastrillon.Models;
public class Customer : User
{
    public string? MemberShipLevel{ get; set; }
    public string? PreferredPaymenMethod { get; set; }

    public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly? birthdate, string email, string phoneNumber, string adreess, string memberShipLevel, string preferredPaymenMethod): base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, adreess)
    {
       MemberShipLevel = memberShipLevel;
       PreferredPaymenMethod = preferredPaymenMethod;   
    }

    public static void UpdateMemberShipLevel(){

    }
}