namespace BorderControlExercise.Models
{
    using BorderControlExercise.Contracts;
    using System;

    public class Robot  : IIdentifiable
    {
        private string id;
        private string model;

        public Robot(string id, string model)
        {
            this.Id = id;
            this.Model = model;
        }

        public string Id
        {
            get => id;

            private set => id = value;
        }
        public string Model
        {
            get => model;
            private set => model = value;
        }
    }
}
