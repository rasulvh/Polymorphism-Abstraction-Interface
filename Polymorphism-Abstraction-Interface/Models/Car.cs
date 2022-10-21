using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    sealed class Car
    {
        public readonly string Name;
        //public string Name { get; private set; }

        public Car()
        {
            Name = "BMW";
        }
    }
}
