using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    public class Student : Person
    {
        //public override string ToString()
        //{
        //    return Name + " " + Surname + " " + Age;
        //}
        public override void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
