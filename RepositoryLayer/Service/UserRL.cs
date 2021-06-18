using CommonLayer;
using Microsoft.IdentityModel.Tokens;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

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

        public string Login(string email, string password)
        {
           var result= _userDbContext.User.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (result == null)
                return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes("hellosdjfgbbsdkjjgbvwbvwruvbwrouvbwrouvwrouvbworuou");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, email)

                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
