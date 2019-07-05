namespace MilitaryEliteExercise.Contracts
{
    using MilitaryEliteExercise.Enums;
    using System;

    public interface IMission
    {
        string CodeName { get; }
        MissionState State { get; }

        void CompleteMission();
        

    }
}
