namespace MilitaryEliteExercise.Models
{
    using MilitaryEliteExercise.Contracts;
    using MilitaryEliteExercise.Enums;
    using System;
    using System.Collections.Generic;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission> { };
        }

        public ICollection<IMission> Missions { get; private set; }

        public override string ToString()
        {
            return base.ToString()
                + $"\nMissions:"
                + (this.Missions.Count == 0 ?
                string.Empty
                : $"\n  {string.Join("\n  ", this.Missions)}");
        }

    }
}
