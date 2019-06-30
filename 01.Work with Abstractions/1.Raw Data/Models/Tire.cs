

namespace P01_RawData.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tire
    {
        private double tirePressure;
        private int tireAge;

        public Tire(double tirePressure, int tireAge)
        {
            TirePressure = tirePressure;
            TireAge = tireAge;
        }

        public double TirePressure { get => tirePressure; set => tirePressure = value; }
        public int TireAge { get => tireAge; set => tireAge = value; }
    }
}
