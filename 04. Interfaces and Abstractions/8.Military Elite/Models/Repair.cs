namespace MilitaryEliteExercise.Models
{
    using System;
    using MilitaryEliteExercise.Contracts;
    public class Repair : IRepair
    {
        string partName;
        int hoursWorked;

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName
        {
            get => partName;
            set => partName = value;
        }

        public int HoursWorked
        {
            get => hoursWorked;
            set => hoursWorked = value;
        }


        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.hoursWorked}";
        }

    }
}
