using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef het vak op: ");
            string subject = Console.ReadLine();

            Console.Write("Hoeveel studenten hebben de toets gedaan: ");
            int studentsAttended = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            string[] studentNames = new string[studentsAttended];
            for (int i = 0; i < studentNames.Length; i++) {
                Console.Write($"Geef de naam van student {i + 1}: ");
                studentNames[i] = Console.ReadLine();
            }

            Console.WriteLine("");

            double[] studentGrades = new double[studentsAttended];
            for (int i = 0; i < studentGrades.Length; i++) {
                Console.Write($"Geef het cijfer van {studentNames[i]}: ");
                studentGrades[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            Console.WriteLine("Het gemiddelde cijfer is: {0}", studentGrades.Average());
            Console.WriteLine("Het hoogst behaalde cijfer is: {0}", studentGrades.Max());

            Console.WriteLine("");

            for (int i = 0; i < studentNames.Length; i++) {
                Console.WriteLine($"Student {studentNames[i]} heeft voor het vak {subject} een {studentGrades[i]} gehaalt");
            }

            Console.ReadKey();
        }
    }
}
