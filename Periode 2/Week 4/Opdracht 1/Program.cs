using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.Input;
using System.IO;

namespace Opdracht1 {
    class Program {
        Input input = new Input();

        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            Main(args); // For testing
        }

        void start() {
            string name = input.readString("Geef uw naam: ");
            string fileName = $"./{name}.txt";

            if (File.Exists(fileName)) {
                Console.WriteLine("Wat leuk om u hier weer te zien!");

                bool fileIntact = checkFileIntact(fileName);

                if (fileIntact) {
                    Console.WriteLine("We hebben de volgende gegevens van u:");

                    Person person = readPersonFromFile(fileName);

                    showPerson(person);
                } else {
                    Console.WriteLine("Wij hebben gegevens van u maar deze kunnen niet worden ingelezen op dit moment.");
                }
            } else {
                Console.WriteLine("Welkom nieuweling!");

                Person person = readPerson();

                writePersonToFile(person, fileName);

                Console.WriteLine("Uw gegevens zijn opgeslagen.");
            }

            Console.ReadKey();
        }

        Person readPerson() {
            Person person = new Person();

            person.name = input.readString("Geef een naam: ");
            person.residence = input.readString("Geef een woonplaats: ");
            person.age = input.readInt("Geef een leeftijd: ", 0, 170);

            return person;
        }

        void showPerson(Person person) {
            Console.WriteLine($"Naam: {person.name}");
            Console.WriteLine($"Woonplaats: {person.residence}");
            Console.WriteLine($"Leeftijd: {person.age}");
        }

        void writePersonToFile(Person person, string fileName) {
            StreamWriter streamWriter = new StreamWriter(fileName);

            streamWriter.WriteLine(person.name);
            streamWriter.WriteLine(person.residence);
            streamWriter.WriteLine(person.age);

            streamWriter.Close();
        }

        bool checkFileIntact(string fileName) {
            StreamReader streamReader = new StreamReader(fileName);

            streamReader.ReadLine();
            streamReader.ReadLine();

            bool ageValid = int.TryParse(streamReader.ReadLine(), out int _);

            streamReader.Close();

            return ageValid;
        }

        Person readPersonFromFile(string fileName) {
            StreamReader streamReader = new StreamReader(fileName);

            Person person = new Person();

            person.name = streamReader.ReadLine();
            person.residence = streamReader.ReadLine();

            person.age = int.Parse(streamReader.ReadLine());

            streamReader.Close();

            return person;
        }
    }
}
