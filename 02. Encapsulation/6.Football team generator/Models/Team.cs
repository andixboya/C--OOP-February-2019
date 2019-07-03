

namespace FootballTeamGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Team
    {
        private string name;
        private readonly Dictionary<string,Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new Dictionary<string, Player>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
                    )
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public double AverageSkillOfAllPlayers
        {
            get
            {
                double result = 0;

                if (this.players.Count!=0)
                {
                    result = this.players.Average(p => p.Value.AverageStatsOfPlayer);

                }

                return  result;
            }
        }

        public IReadOnlyCollection<Player> Players => this.players.Select(p => p.Value).ToList().AsReadOnly();

        public void AddPlayer(Player player)
        {
            this.players.Add(player.Name, player);
        }

        public void RemovePlayer (string playerName)
        {
            if (!this.players.ContainsKey(playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(playerName);

        }

        public override string ToString()
        {
            return $"{this.Name} - {this.AverageSkillOfAllPlayers:f0}";
        }
    }
}
