using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4 {
    class PaneelController: IPaneelControler {
        private ZonnepaneelSysteem system;

        public PaneelController(ZonnepaneelSysteem system) {
            this.system = system;
        }

        public void newMeasurement() => system.newMeasurement();
    }
}
