using System;
using System.Collections.Generic;

namespace Opdracht_3 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Tank tank = new Tank();
            tank.assignDriver("Frank");

            Robot robot = new Robot();
            robot.moveByPerson("Mark");

            List<IAttacker> attackers = new List<IAttacker>() {
                tank,
                new RobotAdapter(robot)
            };

            foreach (IAttacker attacker in attackers) {
                Console.WriteLine();

                attacker.driveForward(3);
                attacker.useWeapon();
            }

            Console.ReadKey();
        }
    }
}
