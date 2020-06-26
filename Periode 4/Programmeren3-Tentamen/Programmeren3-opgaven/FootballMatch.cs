namespace Programmeren3_opgaven {
    abstract class FootballMatch {
        public FootballTeam homeTeam;
        public FootballTeam awayTeam;

        public FootballMatch(FootballTeam homeTeam, FootballTeam awayTeam) {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
        }
    }
}
