namespace MilitaryEliteExercise.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ICommando : ISpecialisedSoldier 
    {

        ICollection<IMission> Missions { get; }

    }

    
}
