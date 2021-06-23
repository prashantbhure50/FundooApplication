using CommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer
{
    public interface IUserBL
    {
        bool SampleUserApi(Users user);
        Users AddUser(Users user);
        string Login(string email, string password);
        
    }
}
