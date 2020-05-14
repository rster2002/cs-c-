using System;
using System.Collections.Generic;

namespace Opdracht_1 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            List<Character> characters = new List<Character>() {
                new Queen(),
                new Troll(),
                new King(),
                new Knight()
            };

            makeCharactersFight(characters);

            characters[3].weapon = new AxeBehaviour();
            Console.WriteLine();

            makeCharactersFight(characters);

            Console.ReadKey();
        }

        void makeCharactersFight(List<Character> characters) {
            foreach (Character character in characters) {
                character.fight();
            }
        }
    }
}
