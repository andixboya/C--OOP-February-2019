namespace WildFarm.Food.Models
{
    using System;
    using WildFarm.Food.Contracts;

    public class Food : IFood
    {
        private int quantity;

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        
    }
}
