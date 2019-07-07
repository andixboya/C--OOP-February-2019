namespace WildFarm.Animals.Models.Birds
{
    using System;
    using WildFarm.Food.Models;

    public abstract class Bird : Animal 
    {

        private double wingSize;

        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize
        {
            get { return wingSize; }
            set { wingSize = value; }
        }

        public override string ToString()
        {
            return base.ToString()+$"{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

    }
}
