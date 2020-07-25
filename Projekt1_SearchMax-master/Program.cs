using System;
using System.Security.Cryptography;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int liczba = random.Next(0, 37);
            for (int i = 0; i < 11; i++)
            {
                liczba = random.Next(0, 37);
                Console.WriteLine(liczba);
            }
        }
    }
}
