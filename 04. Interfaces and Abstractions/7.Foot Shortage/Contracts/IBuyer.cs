namespace BorderControlExercise.Contracts
{
    using System;

    public interface IBuyer
    {
        int Food { get; }
        string Name { get;  }
        void BuyFood();


    }
}
