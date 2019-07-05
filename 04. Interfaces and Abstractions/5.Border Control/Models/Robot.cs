

namespace BorderControlSecond.Models
{
    using BorderControlSecond.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Robot : IIdentifiable
    {
        private string id;
        private string model;

        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public string Id
        {
            get => id;

            private set
            {
                id = value;
            }
        }
        public string Model
        {
            get => model;

            private set
            {
                model = value;
            }
        }
    }
}
