using CommonLayer;
using System;
using System.Collections.Generic;

namespace RepositoryLayer
{
    public class UserRL:IUserRL
    {
        IList<User> Users = new List<User>();
        public bool SampleUserApi(User newUser)
        {
            try
            {
                Users.Add(newUser);
                if (Users.Contains(newUser) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
