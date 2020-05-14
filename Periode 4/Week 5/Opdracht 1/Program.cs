using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Logger logger = Logger.create();
            logger.logLine("Main", "Starting");

            MainSystem mainSystem = new MainSystem();
            mainSystem.doSomeMainWork();

            logger.logLine("Main", "finishing");
            Console.ReadKey();
        }
    }
}
