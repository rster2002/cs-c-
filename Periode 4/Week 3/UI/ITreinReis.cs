using System.Collections.Generic;

namespace Model {
    public interface ITreinReis {
        List<ITreinDisplay> treinReisObservers { get; set; }

        void addObserver(ITreinDisplay observer);
        void removeObserver(ITreinDisplay observer);
        void volgendStation();
        void voegStationToe(TreinStation treinStation);
    }
}
