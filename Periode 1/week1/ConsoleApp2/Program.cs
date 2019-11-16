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
            int age = int.Parse(Console.ReadLine());

            age *= 10;

            Console.WriteLine("Next year your age is " + age.ToString());

            Console.ReadKey();

        }
    }
}
