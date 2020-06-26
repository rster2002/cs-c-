namespace Programmeren3_opgaven {
    class FootballPlayer {
        protected string name;
        protected int age;

        public FootballPlayer(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public virtual int calculateTransferValue() {
            return (27 - age) * 2;
        }

        public override string ToString() {
            return $"{name} ({age}), transfervalue: {calculateTransferValue()}m";
        }
    }
}
