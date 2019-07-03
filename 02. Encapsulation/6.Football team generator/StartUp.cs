

namespace FootballTeamGenerator
{
    using FootballTeamGenerator.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();


            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] partitions = input.Split(";");
                string command = partitions[0];
                string teamName = partitions[1];

                try
                {
                    switch (command)
                    {

                        case "Team":
                            Team currentTeam = new Team(teamName);
                            teams.Add(teamName, currentTeam);
                            break;


                        case "Add":
                            if (!teams.Any(t => t.Value.Name == teamName))
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }

                            string playerName = partitions[2];
                            int endurance = int.Parse(partitions[3]);
                            int sprint = int.Parse(partitions[4]);
                            int dribble = int.Parse(partitions[5]);
                            int passing = int.Parse(partitions[6]);
                            int shooting = int.Parse(partitions[7]);
                            Player currentPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                            teams[teamName].AddPlayer(currentPlayer);

                            break;


                        case "Remove":
                            playerName = partitions[2];
                            teams[teamName].RemovePlayer(playerName);

                            break;

                        case "Rating":
                            if (!teams.ContainsKey(teamName))
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }

                            var team = teams[teamName];
                            Print(team.ToString());

                            break;
                    }

                }
                catch (ArgumentException e)
                {
                    Print(e.Message);
                }
                

                input = Console.ReadLine();

            }

        }

        private static void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
