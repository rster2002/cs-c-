using System;

namespace Opdracht_1 {
    class Programmer {
        public string name;
        public Speciality speciality;

        public Programmer(string name) {
            this.name = name;
            speciality = Speciality.Unknown;
        }

        public Programmer(string name, Speciality speciality) {
            this.name = name;
            this.speciality = speciality;
        }

        public void print() {
            Console.WriteLine($"Name: {name}, Speciality: {speciality}");
        }
    }
}
