using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class CheapHardDisk: IHardDisk {
        public void storeData() {
            Console.WriteLine("Why does copying one file take forever?");
        }
    }
}
