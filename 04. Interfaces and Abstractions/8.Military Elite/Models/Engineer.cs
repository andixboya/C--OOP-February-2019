namespace MilitaryEliteExercise.Models
{
    using MilitaryEliteExercise.Contracts;
    using MilitaryEliteExercise.Enums;
    using System;
    using System.Collections.Generic;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair> { };
        }

        public ICollection<IRepair> Repairs { get; private set; }


        public override string ToString()
        {
            return base.ToString()+"\nRepairs:"+
                (this.Repairs.Count==0? 
                string.Empty 
                : $"\n  {string.Join("\n  ",this.Repairs)}");
        }
    }

    
}
