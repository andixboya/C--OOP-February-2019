namespace MilitaryEliteExercise.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        ICollection<IRepair> Repairs { get; }



    }
}
