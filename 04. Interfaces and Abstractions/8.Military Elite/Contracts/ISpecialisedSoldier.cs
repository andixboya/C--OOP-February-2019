namespace MilitaryEliteExercise.Contracts
{
    using System;
    using MilitaryEliteExercise.Enums;

    public interface ISpecialisedSoldier :IPrivate
    {
        Corps Corps { get; }

        

    }
}
