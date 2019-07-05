using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControlSecond.Models
{
    public class Pet : Identity
    {
        public Pet(string name, DateTime birthDate) 
            : base(name, birthDate)

        {

        }
    }
}
