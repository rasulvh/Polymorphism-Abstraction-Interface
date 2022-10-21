using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat sound");
        }
    }
}
