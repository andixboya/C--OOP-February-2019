namespace WildFarm.Animals.Contracts
{
    using System;

    public interface IFeline : IMammal
    {
        string Breed { get; }

    }
}
