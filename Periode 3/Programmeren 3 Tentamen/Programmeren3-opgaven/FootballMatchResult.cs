namespace Programmeren3_opgaven {
    class FootballMatchResult {
        public int homeTeamGoals { get; private set; }
        public int awayTeamGoals { get; private set; }
        public int homeTeamPoints {
            get {
                return calculatePointsForTeam(homeTeamGoals, awayTeamGoals);
            }
        }

        public int awayTeamPoints {
            get {
                return calculatePointsForTeam(awayTeamGoals, homeTeamGoals);
            }
        }

        private int calculatePointsForTeam(int calculatingTeamGoals, int otherTeamGoals) {
            if (calculatingTeamGoals == otherTeamGoals) return 1;
            else if (calculatingTeamGoals > otherTeamGoals) return 3;
            else return 0;
        }

        public FootballMatchResult(int homeTeamGoals, int awayTeamGoals) {
            this.homeTeamGoals = homeTeamGoals;
            this.awayTeamGoals = awayTeamGoals;
        }
    }
}
