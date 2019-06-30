﻿
namespace P01_RawData.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get => engineSpeed; set => engineSpeed = value; }
        public int EnginePower { get => enginePower; set => enginePower = value; }
    }
}
