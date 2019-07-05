

namespace BorderControlSecond.Models
{
    using BorderControlSecond.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Citizen : IIdentifiable
    {
        private string id;
        private string name;
        private int age;

        public Citizen(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string Id
        {
            get => id;

            private set
            {
                id = value;
            }
        }

        public string Name
        {
            get => name;

            private set
            {
                name = value;
            }
        }
        public int Age
        {
            get => age;

            private set
            {
                age = value;
            }
        }
    }
}
