using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class CheapProcessor: IProcessor {
        public void performOperation() {
            Console.WriteLine("This processor is so impossibly slow");
        }
    }
}
