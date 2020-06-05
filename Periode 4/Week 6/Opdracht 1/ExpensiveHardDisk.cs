using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class ExpensiveHardDisk: IHardDisk {
        public void storeData() {
            Console.WriteLine("Storing data very quickly");
        }
    }
}
