using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface
{
    interface IUser
    {
        void Login(string username, string password);
        string SendEMail(string email);
    }
}
