

namespace BorderControlSecond.Models
{
    using BorderControlSecond.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Citizen : Identity
    {
        
       
        private int age;
        private string id;

        public Citizen(string name, string id ,int age, DateTime birthDate) 
            : base(name, birthDate)
        {
            this.Id = id;
            this.Age = age;
        }

       
        public int Age
        {
            get => age;

            private set
            {
                age = value;
            }
        }

        public string Id
        {
            get => id;

            private set
            {
                id = value;
            }
        }
    }
}
