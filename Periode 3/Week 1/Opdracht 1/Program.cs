using System;

namespace Opdracht_1 {
    class Program {

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Team team = new Team();

            team.addProgrammer(new Programmer("Programmer 1") {
                speciality = Speciality.Csharp
            });
            team.addProgrammer(new Programmer("Programmer 2") {
                speciality = Speciality.Java
            });
            team.addProgrammer(new Programmer("Programmer 3") {
                speciality = Speciality.JavaScript
            });
            team.addProgrammer(new Programmer("Programmer 4") {
                speciality = Speciality.PHP
            });
            team.addProgrammer(new Programmer("Programmer 5"));

            team.printAllMembers();

            Console.ReadKey();
        }
    }
}
