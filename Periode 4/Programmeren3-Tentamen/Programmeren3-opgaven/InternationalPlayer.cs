namespace Programmeren3_opgaven {
    class InternationalPlayer: FootballPlayer {
        private int gamesPlayed;

        public InternationalPlayer(string name, int age, int gamesPlayed): base(name, age) {
            this.gamesPlayed = gamesPlayed;
        }

        public override int calculateTransferValue() {
            return base.calculateTransferValue() + (int) (.5 * gamesPlayed);
        }

        public override string ToString() {
            return base.ToString() + $" ({gamesPlayed} int. games)";
        }
    }
}
