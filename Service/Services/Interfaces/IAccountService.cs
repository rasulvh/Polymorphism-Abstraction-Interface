using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface IAccountService
    {
        void Register(string username, string password);
    }
}
