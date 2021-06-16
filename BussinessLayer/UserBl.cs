using CommonLayer;
using RepositoryLayer;
using System;

namespace BussinessLayer
{
    public class UserBL : IUserBL
    {
        private IUserRL userRl;
        public UserBL(IUserRL userRl)
        {
            this.userRl = userRl ;
        }
        public bool SampleUserApi(User user)
        {
            try
            {
                return this.userRl.SampleUserApi(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
