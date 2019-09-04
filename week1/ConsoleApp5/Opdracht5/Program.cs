using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int[] numbers = { rnd.Next(101, 10000), rnd.Next(101, 10000), rnd.Next(101, 10000), rnd.Next(101, 10000) };

            Console.WriteLine("Add the following numbers together:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number.ToString());
            }

            int answer;
            bool isCorrectType = int.TryParse(Console.ReadLine(), out answer);

            if (isCorrectType)
            {
                Console.WriteLine($"That's the { (answer == numbers.Sum() ? "right" : "wrong") } answer");
            } else
            {
                Console.WriteLine("The input was a string, not a number");
            }
            

            Console.ReadKey();

        }
    }
}
