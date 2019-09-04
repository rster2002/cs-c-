using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {

            int score = 200;
            int level = 3;
            int aantalItems = 4;

            int score_nieuw = score,
                level_nieuw = level;

            // verhoog score en level

            score_nieuw++;
            level_nieuw++;

            Console.WriteLine("Score (oud): {0}, score (nieuw): {1}", score, score_nieuw);
            Console.WriteLine("level (oud): {0}, level (nieuw): {1}", level, level_nieuw);

            aantalItems += 5;
            Console.WriteLine("aantal items: {0}", aantalItems);

            // wacht totdat de gebruiker een toets indrukt
            Console.ReadKey();

        }
    }
}
