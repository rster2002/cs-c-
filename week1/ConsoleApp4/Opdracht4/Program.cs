using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            //bool toOld = age >= 65;

            //Console.WriteLine($"boolean antwoord: {toOld}");

            Console.WriteLine(age >= 65 ? "Je bent te oud" : "Prima leeftijd");

            // wacht totdat de gebruiker een toets indrukt
            Console.ReadKey();
        }
    }
}
