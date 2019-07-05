using BorderControlSecond.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControlSecond.Models
{
    public abstract class Identity : IBirthdatable, IIdentifiable
    {
        private string name;
        private DateTime birthDate;

        protected Identity(string name, DateTime birthDate)
        {
            this.Id = name;
            this.BirthDate = birthDate;
        }

        public string Id
        {
            get => name;

            private set
            {
                name = value;
            }
        }
        public DateTime BirthDate
        {
            get => birthDate;

            private set
            {
                birthDate = value;
            }
        }

        //public string Id => throw new NotImplementedException();

        //public DateTime BirthDate => throw new NotImplementedException();
    }
}
