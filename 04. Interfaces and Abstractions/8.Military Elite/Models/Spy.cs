namespace MilitaryEliteExercise.Models
{
    using MilitaryEliteExercise.Contracts;
    using System;
    public class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public Spy(string id, string firstName, string lastName,int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }


        public int CodeNumber
        {
            get => codeNumber;
            set => codeNumber = value;
        }

        public override string ToString()
        {
            return base.ToString()+$"\nCode Number: {this.CodeNumber}";
        }
    }
}
