using CommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public interface IUserRL
    {
        bool SampleUserApi(Users user);
        Users AddUser(Users user);
       string Login(string email, string password);
        //bool ForgotPassword(string email);
    }
}
