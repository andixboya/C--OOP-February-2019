namespace WildFarm.Animals.Contracts
{
    using System;

    public interface IMammal : IAnimal
    {
        string LivingRegion { get; }

    }
}
