namespace WildFarm.Food.Models
{
    using System;
    using WildFarm.Food.Contracts;

    public class Seeds : Food

    {
        public Seeds(int quantity) 
            : base(quantity)
        {

        }
    }
}
