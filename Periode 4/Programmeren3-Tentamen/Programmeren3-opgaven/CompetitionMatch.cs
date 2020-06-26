namespace Programmeren3_opgaven {
    class CompetitionMatch: FootballMatch {
        private int roundNumber;

        public CompetitionMatch(FootballTeam homeTeam, FootballTeam awayTeam, int roundNumber): base(homeTeam, awayTeam) {
            this.roundNumber = roundNumber;
        }
    }
}
