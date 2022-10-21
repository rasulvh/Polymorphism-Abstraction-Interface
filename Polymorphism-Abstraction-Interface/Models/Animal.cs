using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
