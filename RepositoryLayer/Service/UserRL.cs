using CommonLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryLayer
{
    public class UserRL:IUserRL
    {
        IList<Users> Users = new List<Users>();
        public bool SampleUserApi(Users newUser)
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
        private UserContext _userDbContext;
        public UserRL(UserContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public Users AddUser(Users newuser)
        {
            _userDbContext.User.Add(newuser);
            _userDbContext.SaveChanges();
            return newuser;
        }





    }
}
