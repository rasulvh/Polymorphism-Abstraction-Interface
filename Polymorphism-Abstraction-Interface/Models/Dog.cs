using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog sound");
        }
    }
}
