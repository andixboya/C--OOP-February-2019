

namespace FootballTeamGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Player
    {
        private string name;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
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

        internal int Endurance
        {
            get => this.endurance;

            private set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException($"{nameof(this.Endurance)} should be between 0 and 100.");

                }

                this.endurance = value;
            }
        }
        internal int Sprint
        {
            get => this.sprint;

            private set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException($"{nameof(this.Sprint)} should be between 0 and 100.");

                }

                this.sprint = value;
            }
        }
        internal int Dribble
        {
            get => this.dribble;

            private set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException($"{nameof(this.Dribble)} should be between 0 and 100.");

                }

                this.dribble = value;
            }
        }
        internal int Passing
        {
            get => this.passing;

            private set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException($"{nameof(this.Passing)} should be between 0 and 100.");

                }

                this.passing = value;
            }
        }
        internal int Shooting
        {
            get => this.shooting;

            private set
            {

                if (!IsValid(value))
                {
                    throw new ArgumentException($"{nameof(this.Shooting)} should be between 0 and 100.");
                }

                this.shooting = value;
            }
        }

        private bool IsValid(int value)
        {
            return value >= 0 && value <= 100;
        }

        //TODO
        public double AverageStatsOfPlayer
        {
            get
            {
                double result = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.shooting) / 5.00;

                return result;
            }

        }

    }
}
