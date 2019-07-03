
using System;
using System.Collections.Generic;

namespace P05_PizzaCalories.Models
{

    public class Dough
    {

        private const double caloriesPerGram = 2;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        private Dictionary<string, double> flourTypes;
        private Dictionary<string, double> bakingTechniques;

        


        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.SeedBakingTechniques();
            this.SeedFlourTypes();

            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            
        }

        public string FlourType
        {
            get => flourType;

            private set
            {
                if (!this.flourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;

            private set
            {
                if (!this.bakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => weight;

            private set
            {
                if (1>value || value>200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double GetDoughCalories()
        {
            double result= caloriesPerGram * this.Weight * this.flourTypes[FlourType.ToLower()] * this.bakingTechniques[BakingTechnique.ToLower()];

            return result;

        }

        private void SeedFlourTypes()
        {
            this.flourTypes = new Dictionary<string, double>();
            this.flourTypes.Add("white", 1.5);
            this.flourTypes.Add("wholegrain", 1.0);
        }

        private void SeedBakingTechniques()
        {
            this.bakingTechniques = new Dictionary<string, double>();
            this.bakingTechniques.Add("crispy", 0.9);
            this.bakingTechniques.Add("chewy", 1.1);
            this.bakingTechniques.Add("homemade",1.0);
        }

    }
}
