using Opdracht_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Console.WriteLine("[shop creating actual good computers]");
            ComputerShop highEndComputerShop = new ComputerShop(new HighBudgetFactory());
            highEndComputerShop.buildComputer();
            highEndComputerShop.runComputer();

            Console.WriteLine();
            Console.WriteLine("[shop creating crappy computers]");
            ComputerShop crappyComputerShop = new ComputerShop(new LowBudgetFactory());
            crappyComputerShop.buildComputer();
            crappyComputerShop.runComputer();


            Console.ReadKey();
        }
    }
}
