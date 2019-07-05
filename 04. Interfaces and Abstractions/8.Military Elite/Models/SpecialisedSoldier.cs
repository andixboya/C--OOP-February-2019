namespace MilitaryEliteExercise.Models
{
    using MilitaryEliteExercise.Contracts;
    using MilitaryEliteExercise.Enums;
    using System;
    public abstract class SpecialisedSoldier :  Private,ISpecialisedSoldier

    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
            
        }

        public Corps Corps
        {
            get; set;
        }

        public override string ToString()
        {
            return base.ToString()+$"\nCorps: {this.Corps}";
        }

    }
}
