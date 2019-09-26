using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Primes {
    class Program {

        static bool checkPrime(int number) {
            bool isPrime = true;

            int i = 2;
            while (isPrime && i < number) {
                if (number % i == 0) {
                    isPrime = false;
                }

                i++;
            }

            return isPrime;
        }
        static void Main(string[] args) {
            Console.Write("Until which number do you want to check primes: ");
            int maxCheck = int.Parse(Console.ReadLine());

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string allPrimes = "";

            for (int i = 1; i <= maxCheck; i++) {
                bool isPrime = false;

                if (i % 2 == 0) { isPrime = false; }
                if (i == 2) { isPrime = true; }

                if (!isPrime) {
                    isPrime = checkPrime(i);
                }

                if (isPrime) {
                    Console.WriteLine(i);

                    allPrimes += i.ToString() + "\n";
                }
            }

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("Done within: {0}", elapsedTime);
            System.IO.File.WriteAllText(@"C:\Data\WriteText.txt", allPrimes);

            Console.ReadKey();
        }
    }
}
