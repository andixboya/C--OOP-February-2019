namespace BorderControlExercise.Models
{
    using BorderControlExercise.Contracts;
    using System;
    public class Pet : IBirthable
    {
        private string name;
        private string birthDay;

        public Pet(string name, string birthDay)
        {
            this.Name = name;
            this.BirthDay = birthDay;

        }

        public string Name { get => name; private set => name = value; }
        public string BirthDay { get => birthDay; private set => birthDay = value; }
    }
}
