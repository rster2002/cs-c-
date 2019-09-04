using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give your age:");
            string ageInput = Console.ReadLine();

            int age = int.Parse(ageInput);

            age = age + 1;

            string output = age.ToString();
            Console.WriteLine($"Next year your age is {age}");

            Console.ReadKey();

        }
    }
}
