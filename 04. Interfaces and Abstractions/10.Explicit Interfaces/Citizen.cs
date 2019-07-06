namespace ExplicitInterfaces
{
    using ExplicitInterfaces.Contracts;
    using System;

    public class Citizen : IResident, IPerson
    {
       
        public string Name { get ; set ; }
        public int Age { get ; set ; }
        public string Country { get ; set ; }

        public Citizen(string name)
        {
            this.Name = name;

        }
        
        string IResident.GetName()
        {

            return $"Mr/Ms/Mrs {this.Name}";
        }

         string IPerson.GetName()
        {
            return $"{this.Name}";
        }
    }
}
