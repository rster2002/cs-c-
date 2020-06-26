using System;
using System.Collections.Generic;

namespace Programmeren3_opgaven {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            opgave1();
            opgave2();
            opgave3();
            opgave5();
            opgave6();

            Console.ReadKey();
        }

        void opgave1() {
            FootballPlayer footballPlayer = new FootballPlayer("Peter de Groot", 25);
            Console.WriteLine(footballPlayer);
        }

        void opgave2() {
            List<FootballPlayer> footbalPlayers = new List<FootballPlayer>();

            footbalPlayers.Add(new FootballPlayer("Peter de Groot", 25));
            footbalPlayers.Add(new InternationalPlayer("Donny van der beek", 23, 9));
            footbalPlayers.Add(new InternationalPlayer("Hakim Ziyech", 27, 32));

            foreach (FootballPlayer footballPlayer in footbalPlayers) {
                Console.WriteLine(footballPlayer);
            }
        }

        void opgave3() {
            FootballTeam footballTeam = new FootballTeam("Ajax");
            footballTeam.footballPlayers.Add(new FootballPlayer("Peter de Groot", 25));
            footballTeam.footballPlayers.Add(new InternationalPlayer("Donny van der beek", 23, 9));
            footballTeam.footballPlayers.Add(new InternationalPlayer("Hakim Ziyech", 27, 32));

            Console.WriteLine(footballTeam.name);

            foreach (FootballPlayer footballPlayer in footballTeam.footballPlayers) {
                Console.WriteLine(footballPlayer);
            }

            Console.WriteLine($"Total transfervalue: {footballTeam.totalTransferValue}");
        }

        void opgave5() {
            List<FootballMatchResult> footballMatchResults = new List<FootballMatchResult>();
            footballMatchResults.Add(new FootballMatchResult(2, 1));
            footballMatchResults.Add(new FootballMatchResult(3, 3));
            footballMatchResults.Add(new FootballMatchResult(1, 5));

            foreach (FootballMatchResult footballMatchResult in footballMatchResults) {
                Console.WriteLine($"Football match result: {footballMatchResult.homeTeamGoals} - {footballMatchResult.awayTeamGoals}");
                Console.WriteLine($"Home points: {footballMatchResult.homeTeamPoints}");
                Console.WriteLine($"Away points: {footballMatchResult.awayTeamPoints}");
                Console.WriteLine();
            }
        }

        void opgave6() {
            Competition competition = new Competition();
            competition.teams.Add(new FootballTeam("Ajax"));
            competition.teams.Add(new FootballTeam("AZ"));
            competition.teams.Add(new FootballTeam("Feyenoord"));
            competition.teams.Add(new FootballTeam("PSV"));

            competition.generateMatches();

            // Controle van de opdracht
            Random random = new Random();

            foreach (FootballMatch footballMatch in competition.matches) {
                competition.addResultsToMatch(footballMatch, new FootballMatchResult(random.Next(0, 7), random.Next(0, 5)));
            }

            competition.calculateTeamPoints();

            foreach (FootballTeam footballTeam in competition.teams) {
                Console.WriteLine($"{footballTeam.name}: {footballTeam.totalPoints}");
            }
        }
    }
}
