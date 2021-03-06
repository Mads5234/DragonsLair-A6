﻿using System;
using TournamentLibrary;
using System.IO;

namespace DragonsLair
{
    public class Menu
    {
        private Controller control = new Controller();
        
        public void Show()
        {
            bool running = true;
            do
            {
                ShowMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        ShowScore();
                        break;
                    case "2":
                        ScheduleNewRound();
                        break;
                    case "3":
                        SaveMatch();
                        break;
                    case "4":
                        AddPlayers();
                        break;
                    case "5":
                        ViewTeamList();
                        break;
                    case "6":
                        ModifyTeam();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            Console.WriteLine("Dragons Lair");
            Console.WriteLine();
            Console.WriteLine("1. Præsenter turneringsstilling");
            Console.WriteLine("2. Planlæg runde i turnering");
            Console.WriteLine("3. Registrér afviklet kamp");
            Console.WriteLine("4. Tilføj spillere til hold");
            Console.WriteLine("5. Se liste over hold");
            Console.WriteLine("6. Ændre holdlist");
            Console.WriteLine("");
            Console.WriteLine("0. Exit");
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        
        private void ShowScore()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Clear();
            control.ShowScore(tournamentName);
        }

        private void ScheduleNewRound()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Clear();
            control.ScheduleNewRound(tournamentName);
        }

        private void SaveMatch()
        {
            {
                Console.Write("Angiv navn på turnering: ");
                string tournamentName = Console.ReadLine();
                Console.Write("Angiv runde: ");
                int round = int.Parse(Console.ReadLine());
                Console.Write("Angiv vinderhold: ");
                string winner = Console.ReadLine();
                Console.Clear();
                control.SaveMatch(tournamentName, round, winner);
            }

        }
        private void AddPlayers()
        {

            Console.WriteLine("Angiv holdnavn");
            Players.TeamName();
            Console.WriteLine("angiv spiller 1");
            Players.TeamName();
            Console.WriteLine("angiv spiller 2");
            Players.TeamName();
            Console.WriteLine("angiv spiller 3");
            Players.TeamName();
            Console.WriteLine("angiv spiller 4");
            Players.TeamName();
            Console.WriteLine("Hold færdigt");
        }
        private void ViewTeamList()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hold for VinterTurnering");
            Players.TeamReader();
        }
        private void ModifyTeam()
        {
            Players.TeamReader();
            Players.TeamModifier();
        }
    }
}