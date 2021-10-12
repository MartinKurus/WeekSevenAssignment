using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastname = Console.ReadLine();
            Console.WriteLine($"Tervist, {firstName[0]}. {lastname[0]}");
        }
    }
}
