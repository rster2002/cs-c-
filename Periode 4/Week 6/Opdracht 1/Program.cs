using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Console.WriteLine("[shop creating actual good computers]");
            HighBudgetShop highEndTechShop = new HighBudgetShop();
            highEndTechShop.createComputer();
            highEndTechShop.runComputer();

            Console.WriteLine();
            Console.WriteLine("[shop creating crappy computers]");
            LowBudgetShop crappyTechShop = new LowBudgetShop();
            crappyTechShop.createComputer();
            crappyTechShop.runComputer();

            Console.ReadKey();
        }
    }
}
