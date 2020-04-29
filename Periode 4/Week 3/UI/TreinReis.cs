using System.Collections.Generic;

namespace Model {
    public class TreinReis:ITreinReis {
        private List<TreinStation> stations = new List<TreinStation>();
        private int huidigStationIndex = 0;

        private TreinStation huidigStation { get { return stations[huidigStationIndex]; } }

        public List<ITreinDisplay> treinReisObservers { get; set; }

        public TreinReis() {
            treinReisObservers = new List<ITreinDisplay>();
        }

        public void voegStationToe(TreinStation treinStation) => stations.Add(treinStation);

        public void volgendStation() {
            huidigStationIndex++;

            if (huidigStationIndex == stations.Count) {
                huidigStationIndex = 0;
            }

            updateObservers();
        }

        private void updateObservers() {
            foreach (ITreinDisplay observer in treinReisObservers) {
                observer.update(huidigStation);
            }
        }

        public void addObserver(ITreinDisplay observer) {
            treinReisObservers.Add(observer);
            observer.update(huidigStation);
        }

        public void removeObserver(ITreinDisplay observer) => treinReisObservers.Remove(observer);
    }
}
