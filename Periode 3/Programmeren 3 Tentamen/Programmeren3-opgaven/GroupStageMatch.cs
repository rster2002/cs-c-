namespace Programmeren3_opgaven {
    class GroupStageMatch: ChampionshipMatch {
        private string groupName;

        public GroupStageMatch(FootballTeam homeTeam, FootballTeam awayTeam, string groupName): base(homeTeam, awayTeam) {
            this.groupName = groupName;
        }
    }
}
