using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++) {
                persons[i] = readPerson();
                Console.WriteLine();
            }
            
            foreach (Person person in persons) {
                printPerson(person);
                Console.WriteLine();
            }

            persons[0] = celebrateBirthday(persons[0]);

            printPerson(persons[0]);

            Console.ReadKey();
        }

        Person readPerson() {
            Person newPerson;

            newPerson.firstName = readString("Geef een naam: ");
            newPerson.lastName = readString("Geef een achternaam: ");
            newPerson.age = readInt("Geef een leeftijd: ");
            newPerson.residence = readString("Geef een woonplaats: ");
            newPerson.sex = readSex();

            return newPerson;
        }

        void printPerson(Person person) {
            Console.Write("{0} {1} (", person.firstName, person.lastName);
            printSex(person.sex);
            Console.WriteLine(")");

            Console.WriteLine("{0} jaar, {1}", person.age, person.residence);
        }

        void printSex(Sex sex) {
            if (sex == Sex.Male) {
                Console.Write("m");
            } else {
                Console.Write("v");
            }
        }

        Person celebrateBirthday(Person person) {
            Console.WriteLine("Verjaardag vieren van {0} {1}...", person.firstName, person.lastName);
            person.age = person.age + 1;
            return person;
        }

        Sex readSex() {
            while (true) {
                Console.Write("Geef je geslacht (m/v): ");
                string input = Console.ReadLine();

                if (input == "m" || input == "v") {
                    if (input == "m") {
                        return Sex.Male;
                    } else {
                        return Sex.Female;
                    }
                } else {
                    Console.WriteLine("Dit geslacht bestaat niet");
                }
            }
        }

        string readString(string message) {
            Console.Write(message);
            return Console.ReadLine();
        }

        int readInt(string message) {
            bool validNumber;

            Console.Write(message);

            do {
                validNumber = int.TryParse(Console.ReadLine(), out int input);

                if (validNumber) {
                    return input;
                } else {
                    Console.WriteLine("Dit is geen geldig getal");
                    Console.Write(message);
                }
            } while (!validNumber);

            return 0;
        }
    }
}
