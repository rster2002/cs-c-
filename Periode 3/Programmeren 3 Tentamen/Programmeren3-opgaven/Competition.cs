using System.Collections.Generic;

namespace Programmeren3_opgaven {
    class Competition {
        public List<FootballTeam> teams;
        public List<FootballMatch> matches;
        private Dictionary<FootballMatch, FootballMatchResult> resultsMap;

        public Competition() {
            teams = new List<FootballTeam>();
            matches = new List<FootballMatch>();
            resultsMap = new Dictionary<FootballMatch, FootballMatchResult>();
        }

        public void generateMatches() {
            foreach (FootballTeam homeTeam in teams) {
                foreach (FootballTeam awayTeam in teams) {
                    if (homeTeam != awayTeam) {
                        matches.Add(new CompetitionMatch(homeTeam, awayTeam, 1));
                    }
                }
            }
        }

        public void addResultsToMatch(FootballMatch match, FootballMatchResult results) {
            resultsMap[match] = results;
        }

        public void calculateTeamPoints() {
            foreach (KeyValuePair<FootballMatch, FootballMatchResult> keyValuePair in resultsMap) {
                keyValuePair.Key.homeTeam.totalPoints += keyValuePair.Value.homeTeamPoints;
                keyValuePair.Key.awayTeam.totalPoints += keyValuePair.Value.awayTeamPoints;
            }
        }
    }
}
