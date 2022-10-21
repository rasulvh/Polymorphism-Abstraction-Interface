using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface
{
    class User : Test, IUser, ITest
    {
        public void Login(string username, string password)
        {
            Console.WriteLine("Login was succesfull");
        }

        public string SendEMail(string email)
        {
            return "E-Mail was sent";
        }
    }
}
