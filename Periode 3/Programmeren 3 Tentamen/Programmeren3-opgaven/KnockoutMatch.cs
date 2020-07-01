namespace Programmeren3_opgaven {
    class KnockoutMatch: ChampionshipMatch {
        private KnockoutType knockoutType;

        public KnockoutMatch(FootballTeam homeTeam, FootballTeam awayTeam, KnockoutType knockoutType) : base(homeTeam, awayTeam) {
            this.knockoutType = knockoutType;
        }
    }
}
