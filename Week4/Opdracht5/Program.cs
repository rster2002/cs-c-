using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5 {
    class Program {

        static int getYearInput() {
            Console.Write("Geef het jaar dat je wilt checken: ");
            int year = int.Parse(Console.ReadLine());

            if (year >= 0) {
                return year;
            } else {
                Console.WriteLine("Een jaar is een positief geheel getal.");
                return getYearInput();
            }
        }

        static void Main(string[] args) {
            int year = 0;

            do {
                year = getYearInput();
                
                if (year != 0) {
                    bool isLeapYear = false;

                    if (year % 100 != 0) {
                        if (year % 400 == 0 || year % 4 == 0) {
                            isLeapYear = true;
                        }
                    }

                    Console.WriteLine("{0} is{1}een schrikkeljaar", year.ToString(), isLeapYear ? " " : " niet ");
                }
            } while (year != 0);
        }
    }
}
