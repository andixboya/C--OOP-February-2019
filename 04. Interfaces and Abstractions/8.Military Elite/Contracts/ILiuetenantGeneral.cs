namespace MilitaryEliteExercise.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ILiuetenantGeneral : IPrivate
    {
        ICollection<IPrivate> Privates { get; }

    }
}
