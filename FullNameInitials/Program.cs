using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi");
            string userLastName = Console.ReadLine();

            Console.WriteLine($"Tervist {userFirstName[0]}. {userLastName[0]}.");
        }
    }
}