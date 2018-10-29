using System;
using System.Collections.Generic;
using System.Linq;
using TournamentLib;

namespace DragonsLair
{
    public class Controller
    {
        private TournamentRepo tournamentRepository = new TournamentRepo();

        public string score { get; private set; }

        public void ShowScore(string tournamentName)
        {
            score += tournamentName;
            ShowScore();
            /*
             * TODO: Calculate for each team how many times they have won
             * Sort based on number of matches won (descending)
             */
            Console.WriteLine("Score:" + tournamentName);
        }

        public TournamentRepo GetTournamentRepository()
        {
            throw new NotImplementedException();
        }

        void ShowScore()
        {
           Console.WriteLine("Score:" + score);
        }

        public void ScheduleNewRound(string tournamentName, bool printNewMatches = true)
        {
            // Do not implement this method
        }

        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
            // Do not implement this method
        }
    }
}
