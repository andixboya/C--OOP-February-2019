namespace MilitaryEliteExercise.Models
{
    using MilitaryEliteExercise.Contracts;
    using MilitaryEliteExercise.Enums;
    using System;

    public class Mission : IMission
    {

        private string codeName;
        private MissionState state;

        public Mission( string codeName, MissionState state)
        {
            this.CodeName = codeName;
            this.State = state;
        }


        public string CodeName
        {
            get => codeName;
            set => codeName = value;
        }

        public MissionState State
        {
            get => state;
            set
            {
                this.state = value;
            }
        }


        public void CompleteMission()// ???????
        {
            this.State = MissionState.Finished;

        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
