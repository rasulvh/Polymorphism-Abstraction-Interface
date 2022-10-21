using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public void Register(string username, string password)
        {
            Console.WriteLine("Registered");
        }
    }
}
