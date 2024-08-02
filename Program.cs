using System;
using System.Security.Cryptography.X509Certificates;
using simulacroC__AlejandroCastrillon.Models;
class MainClass
{
    public void Main(string[] args)
    {
        Customer customer1 = new Customer("Juan", "Perez", "Pasaporte", "Aw12345678", new DateOnly(1989, 10, 15), "juan@example.com", "+54-911-222-333-33", "Calle 123, 456", "Gold", "Tarjeta de credito");
        Customer customer2 = new Customer("Maria", "Garcia", "Cedula", "78945612", new DateOnly(1992, 5, 10), "maria@example.com", "+54-911-444-555-55", "Calle 456, 789", "Platinum", "PayPal");
        Customer customer3 = new Customer("Pedro", "Jimenez", "Tarjeta de identidad", "98765432", new DateOnly(1990, 7, 20), "pedro@example.com", "+54-911-666-777-77", "Calle 789, 123", "Platinum", "PayPal");
        Driver driver1 = new Driver("julian", "lopez", "cedula", "555555", new DateOnly(1989, 10, 15), "julian@example.com", "+54-444-444-444-44", "Calle 123, 456", "102030", "A2", 10);
        Driver driver2 = new Driver("pedro", "montoya", "Pasaporte", "Aw12345678", new DateOnly(1989, 10, 15), "pedro@example.com", "+54-222-222-222-22", "Calle 123, 456", "405061", "C1", 30);
        Driver driver3 = new Driver("alfonso", "zapata", "cedula", "888888", new DateOnly(1989, 10, 15), "alfonso@example.com", "+54-333-333-333-33", "Calle 123, 456", "506074", "B2", 20);
        Driver driver4 = new Driver("miguel", "gomez", "Pasaporte", "Aw11278496", new DateOnly(1989, 10, 15), "miguel@example.com", "+54-111-111-11", "Calle 123, 456", "607089", "A2", 2);
        Vehicle vehicle1 = new Vehicle(1, "MJO-765", "moto", "3232", "12345678910", 2, driver1);
        Vehicle vehicle2 = new Vehicle(2, "ABC-123", "auto", "1112", "31321312315", 4, driver2);
        Vehicle vehicle3 = new Vehicle(3, "DEF-456", "camioneta", "2223", "41421421426", 6, driver3);
        Vehicle vehicle4 = new Vehicle(4, "GHI-987", "microbus", "4445", "51521521527", 24, driver4);


        Vehicle.vehicles.Add(vehicle1);
        Vehicle.vehicles.Add(vehicle2);
        Vehicle.vehicles.Add(vehicle3);
        Vehicle.vehicles.Add(vehicle4);
        Customer.customers.Add(customer1);
        Customer.customers.Add(customer2);
        Customer.customers.Add(customer3);
        Driver.drivers.Add(driver1);
        Driver.drivers.Add(driver2);
        Driver.drivers.Add(driver3);
        Driver.drivers.Add(driver4);

        while (true)
        {
            Console.WriteLine("\npress any button to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("|======================================================|");
            Console.WriteLine("|                    MENU OPTIONS                      |");
            Console.WriteLine("|======================================================|");
            Console.WriteLine("|    1. View all registered customers                  |");
            Console.WriteLine("|    2. View all registered drivers                    |");
            Console.WriteLine("|    3. See users with 30 years or more                |");
            Console.WriteLine("|    4. Drivers for their driving experience           |");
            Console.WriteLine("|    5. Customers with credit card for payment         |");
            Console.WriteLine("|    6. See drivers with A2 category                   |");
            Console.WriteLine("|======================================================|");
            Console.WriteLine("|                  OTRAS OPCIONES                      |");
            Console.WriteLine("|======================================================|");
            Console.WriteLine("|    7. Update membership level                        |");
            Console.WriteLine("|    8. Update license category                        |");
            Console.WriteLine("|    9. Add experience                                 |");
            Console.WriteLine("|    10. View all registered vehicles                  |");
            Console.WriteLine("|    11. Delete vehicle                                |");
            Console.WriteLine("|    12. Calculate age                                 |");
            Console.WriteLine("|    13. Get persons details                           |");
            Console.WriteLine("|    14. GO OUT :)                                     |");
            Console.WriteLine("|======================================================|");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Customer.AllCustomers(); //ready
                    break;
                case 2:
                    Driver.AllCustomers(); //ready
                    break;
                case 3:
                    User.OverThirty();//NICK
                    break;
                case 4:
                    Driver.ExperieceYears(); //ready
                    break;
                case 5:
                    Customer.CreditCardCustomers(); //ready
                    break;
                case 6:
                    Driver.categoryDriver(); //ready
                    break;
                case 7:
                    Customer.UpdateMemberShipLevel(); //ready
                    break;
                case 8:
                    Driver.UpdateLicenseCategory();//ready
                    break;
                case 9:
                    Driver.AddExperience();//ready
                    break;
                case 10:
                    Vehicle.AllVehicles();//ready
                    break;
                case 11:
                    Vehicle.DeleteVehicle(); //ready
                    break;
                case 12:
                    //User.CalculateAge();
                    break;
                case 13:
                    //User.GetDetailt();
                    break;
                case 14:
                    Console.WriteLine("Gracias por utilizar nuestro programa."); //ready
                    break;
                default:
                    Console.WriteLine("Opción incorrecta, intente nuevamente.");
                    break;
            }
        }

    }
}

