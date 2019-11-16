using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age:");
            string age = Console.ReadLine();

            Console.WriteLine($"Your name is {name} and you are {age}");

            Console.ReadKey();

        }
    }
}
