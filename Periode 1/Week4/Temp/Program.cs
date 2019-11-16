using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef getal :");
            int getal = int.Parse(Console.ReadLine());
            int count = 1;
            int Som = 0;

            while (getal != 0) {
                Console.Write("Geef getal :");
                getal = int.Parse(Console.ReadLine());
                count++;

                if ((getal != 0) && (count % 5 == 0)) {
                    Som = Som + getal;
                }
            }

            Console.Write("Som is :" + Som);
            Console.ReadKey();
        }
    }
}
