namespace WildFarm.Animals.Contracts
{
    using System;

    public interface IBird : IAnimal
    {
        double WingSize { get; }

    }
}
