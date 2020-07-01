using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4 {
    class Program {
        static void Main(string[] args) {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start() {
            // maak een zonnepaneel systeem aan
            IObservable systeem = new ZonnepaneelSysteem();

            // maak een controller  aan
            IPaneelControler controller = new PaneelController((ZonnepaneelSysteem) systeem);

            // maak een display voor het systeem aan
            IObserver observer = new ZonneDisplay((ZonnepaneelSysteem) systeem);

            // doe een aantal metingen
            for (int i = 0; i < 10; i++)
                controller.newMeasurement();

            Console.ReadKey();
        }
    }
}
