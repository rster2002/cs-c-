using System;

namespace Opdracht_3 {
    class Tank: IAttacker {
        public string driver;

        public void assignDriver(string driver) {
            Console.WriteLine($"{driver} is steering the tank");
            this.driver = driver;
        }

        public void driveForward(int positions) {
            Console.WriteLine($"Tank moves {positions} positions forward");
        }

        public void useWeapon() {
            Console.WriteLine("Tank fires a shot");
        }
    }
}
