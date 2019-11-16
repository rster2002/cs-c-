using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5 {
    class Program {

        static void showResults(string categoryName, string singularEntity, int[] categoryArray) {
            Console.WriteLine("\n" + categoryName.ToUpper());

            int totalSum = 0;
            int totalAmount = 0;
            int oldest = 0;
            for (int i = 0; i < categoryArray.Length; i++) {
                int age = categoryArray[i];

                if (age != 0) {
                    Console.WriteLine($"{singularEntity} {i + 1} is {age} jaar oud");

                    totalSum += age;
                    totalAmount++;

                    if (age > oldest) {
                        oldest = age;
                    }
                }
            }

            if (totalAmount > 0) {
                double average = (double) totalSum / totalAmount;
                Console.WriteLine("De gemiddelde {0} is {1}", singularEntity.ToLower(), average);
                Console.WriteLine("De oudste {0} is {1}", singularEntity.ToLower(), oldest);
            }
        }

        static void Main(string[] args) {
            int toddlersIndexAt = 0;
            int childrenIndexAt = 0;
            int adultsIndexAt = 0;
            int[] toddlers = new int[10];
            int[] children = new int[10];
            int[] adults = new int[10];

            int inputNumber;
            do {
                Console.Write("Geef een leeftijd (0=stoppen): ");
                inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber >= 0 && inputNumber <= 4) {
                    toddlers[toddlersIndexAt] = inputNumber;
                    toddlersIndexAt++;
                } else if (inputNumber >= 5 && inputNumber <= 17) {
                    children[childrenIndexAt] = inputNumber;
                    childrenIndexAt++;
                } else if (inputNumber >= 18) {
                    adults[adultsIndexAt] = inputNumber;
                    adultsIndexAt++;
                } else {
                    Console.WriteLine("Dit is geen geldige leeftijd");
                }
            } while (inputNumber != 0);

            showResults("Kleuters", "Kleuter", toddlers);
            showResults("Kinderen", "Kind", children);
            showResults("Volwassenen", "Volwassene", adults);

            Console.ReadKey();
        }
    }
}
