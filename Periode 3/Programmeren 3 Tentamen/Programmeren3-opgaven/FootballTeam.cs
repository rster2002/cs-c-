using System.Collections.Generic;
using System.Linq;

namespace Programmeren3_opgaven {
    class FootballTeam {
        private string backingName;

        public string name { get { return backingName; } }
        public List<FootballPlayer> footballPlayers { get; private set; }
        public int totalPoints { get; set; }
        public int totalTransferValue {
            get {
                return footballPlayers.Sum(footballPlayer => footballPlayer.calculateTransferValue());
            }
        }

        public FootballTeam(string name) {
            backingName = name;
            totalPoints = 0;
            footballPlayers = new List<FootballPlayer>();
        }
    }
}
