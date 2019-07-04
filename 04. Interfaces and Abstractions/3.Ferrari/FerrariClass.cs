

namespace P03Ferrari
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FerrariClass : IDrivable
    {
        public FerrariClass(string driver)
        {
            
            Model = "488-Spider";
            Driver = driver;
        }

        public string CarName { get; private set; }

        public string Model { get; private set; }

        public string Driver { get; private set; }

        public string PushPedal()
        {
            return $"Gas!";
        }

        public string UseBrakes()
        {
            return $"Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.UseBrakes()}/{this.PushPedal()}/{this.Driver}";
        }
    }
}
