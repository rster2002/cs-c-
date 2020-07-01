using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4 {
    class ZonneDisplay: IObserver {
        private ZonnepaneelSysteem system;

        public ZonneDisplay(ZonnepaneelSysteem system) {
            this.system = system;
            system.addObserver(this);
        }

        public void update(int watts) {
            Console.WriteLine($"Nieuwe meeting {watts}");
        }
    }
}
