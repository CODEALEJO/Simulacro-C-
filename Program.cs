using System;
using System.Security.Cryptography.X509Certificates;
using simulacroC__AlejandroCastrillon.Models;
class MainClass
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer("Juan", "Perez", "Pasaporte", "Aw12345678", new DateOnly(1989, 10, 15), "juan@example.com", "+54-911-222-333-33", "Calle 123, 456", "Gold", "Tarjeta de credito");
        Customer customer2 = new Customer("Maria", "Garcia", "Cedula", "78945612", new DateOnly(1992, 5, 10), "maria@example.com", "+54-911-444-555-55", "Calle 456, 789", "Platinum", "PayPal");
        Customer customer3 = new Customer("Pedro", "Jimenez", "Tarjeta de identidad", "98765432", new DateOnly(1990, 7, 20), "pedro@example.com", "+54-911-666-777-77", "Calle 789, 123", "Platinum", "PayPal");
        Driver driver1 = new Driver("julian", "lopez", "cedula", "555555", new DateOnly(1989, 10, 15), "julian@example.com", "+54-444-444-444-44", "Calle 123, 456", "102030", "A2", 10);
        Driver driver2 = new Driver("pedro", "montoya", "Pasaporte", "Aw12345678", new DateOnly(1989, 10, 15), "pedro@example.com", "+54-222-222-222-22", "Calle 123, 456", "405061", "C1", 30);
        Driver driver3 = new Driver("alfonso", "zapata", "cedula", "888888", new DateOnly(1989, 10, 15), "alfonso@example.com", "+54-333-333-333-33", "Calle 123, 456", "506074", "B2", 20);
        Driver driver4 = new Driver("miguel", "gomez", "Pasaporte", "Aw11278496", new DateOnly(1989, 10, 15), "miguel@example.com", "+54-111-111-11", "Calle 123, 456", "607089", "A2", 2);
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
            Console.WriteLine("|    7. GO OUT :)                                      |");
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
                    User.OverThirty();
                    break;
                case 4:
                    Driver.ExperieceYears();
                    break;
                case 5:
                    Customer.CreditCardCustomers(); //ready
                    break;
                case 6:
                    Driver.categoryDriver();
                    break;
                case 7:
                    Console.WriteLine("Gracias por utilizar nuestro programa.");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta, intente nuevamente.");
                    break;
            }
        }

    }
}

