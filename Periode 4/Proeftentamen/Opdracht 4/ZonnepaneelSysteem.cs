using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4 {
    class ZonnepaneelSysteem: IObservable {
        private Random random = new Random();
        private List<IObserver> observers = new List<IObserver>();

        public void addObserver(IObserver observer) => observers.Add(observer);
        public void removeObserver(IObserver observer) => observers.Remove(observer);

        public void newMeasurement() {
            int watts = random.Next(315, 389);
            informObservers(watts);
        }

        private void informObservers(int watts) {
            foreach (IObserver observer in observers) {
                observer.update(watts);
            }
        }
    }
}
