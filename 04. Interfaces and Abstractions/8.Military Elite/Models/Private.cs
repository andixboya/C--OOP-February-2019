namespace MilitaryEliteExercise.Models
{
    using MilitaryEliteExercise.Contracts;
    using System;

    public  class Private : Soldier, IPrivate
    {

        private decimal salary;

        public Private(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }

        public override string ToString()
        {
            return base.ToString()+$" Salary: {this.Salary:f2}";
        }

    }
}
