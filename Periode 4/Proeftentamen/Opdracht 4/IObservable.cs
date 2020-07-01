using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4 {
    interface IObservable {
        void removeObserver(IObserver observer);
        void addObserver(IObserver observer);
        void newMeasurement();
    }
}
