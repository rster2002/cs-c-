using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef je scoren: ");
            int score = int.Parse(Console.ReadLine());

            char grade = 'F';

            if (score >= 90 && score <= 100) {
                grade = 'A';
            } else if (score >= 80 && score <= 89) {
                grade = 'B';
            } else if(score >= 70 && score <= 79) {
                grade = 'C';
            } else if(score >= 60 && score <= 69) {
                grade = 'D';
            } else if(score < 60) {
                grade = 'F';
            }

            Console.WriteLine("Je heb een {0}, daarmee heb je dit vak{1}behaald.", grade, score < 70 ? " niet " : " ");
            Console.ReadKey();
        }
    }
}
