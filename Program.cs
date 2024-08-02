using System;
using simulacroC__AlejandroCastrillon.Models;
class MainClass
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer("Juan", "Perez", "Pasaporte", "Aw12345678", new DateOnly(1989, 10, 15), "juan@example.com", "+54-911-222-333-33", "Calle 123, 456", "Gold", "Credit Card");
        Customer customer2 = new Customer("Maria", "Garcia", "Cedula", "78945612", new DateOnly(1992, 5, 10), "maria@example.com", "+54-911-444-555-55", "Calle 456, 789", "Platinum", "PayPal");
        Customer customer3 = new Customer("Pedro", "Jimenez", "Tarjeta de identidad", "98765432", new DateOnly(1990, 7, 20), "pedro@example.com", "+54-911-666-777-77", "Calle 789, 123", "Platinum", "PayPal");
        // Empleado empleado4 = new Empleado( 4,"Carlos", "Pérez", "12345678", 30, "Desarrollador",66.5 );
        // Empleado empleado2 = new Empleado(2,"Ana", "Gómez", "87654321", 28, "Diseñadora", 1000000);
        // Empleado empleado3 = new Empleado(3,"Luis", "Martínez", "11223344", 35, "Gerente", 665000);
        // Empresa.AddEmploye(empleado4);
        // Empresa.AddEmploye(empleado2);
        // Empresa.AddEmploye(empleado3);


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
            Console.WriteLine("|    7. GO OUT :)                                      |");
            Console.WriteLine("|======================================================|");
            Console.WriteLine("|                  OTRAS OPCIONES                      |");
            Console.WriteLine("|======================================================|");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:
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

