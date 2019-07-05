namespace BorderControlExercise.Models
{
    using BorderControlExercise.Contracts;
    using System;

    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {

        private string name;
        private string id;
        private int age;
        private string birthday;
        private int food;

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            this.BirthDay = birthday;
        }


        public string Name { get => name; private set => name = value; }
        public string Id { get => id; private set => id = value; }
        public int Age { get => age; private set => age = value; }
        public string BirthDay { get => birthday; private set => birthday = value; }
        public int Food
        {
            get
            {
                return this.food;
            }
            private set
            {
                this.food = value;
            }
        }

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}
