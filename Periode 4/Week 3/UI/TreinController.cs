using Model;

namespace UI {
    class TreinController:ITreinController {
        public ITreinReis treinReis;

        public TreinController(ITreinReis treinReis) {
            this.treinReis = treinReis;
        }

        public void volgendStation() {
            treinReis.volgendStation();
        }
    }
}
