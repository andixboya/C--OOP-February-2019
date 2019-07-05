namespace MilitaryEliteExercise.Models
{
    using MilitaryEliteExercise.Contracts;
    using System;
    using System.Collections.Generic;

    public class Leutenant : Private, ILiuetenantGeneral
    {
        private ICollection<IPrivate> privates;


        public Leutenant(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate> { };

        }

        public ICollection<IPrivate> Privates
        {
            get
            {
                return this.privates;
            }

            private set
            {
                this.privates = value;
            }

        }

        public override string ToString()
        {
            return base.ToString() + $"\nPrivates:" +( Privates.Count==0? 
                string.Empty : $"\n  {string.Join("  \n  ",Privates)}");

        }
    }
}
