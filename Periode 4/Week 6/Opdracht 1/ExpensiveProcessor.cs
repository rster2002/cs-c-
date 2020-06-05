using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class ExpensiveProcessor: IProcessor {
        public void performOperation() {
            Console.WriteLine("Proforming operation very quickly");
        }
    }
}
