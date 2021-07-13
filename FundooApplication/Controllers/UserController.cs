using BussinessLayer;
using CommonLayer;
using CommonLayer.DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooApplication.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
   
    public class UserController : ControllerBase
    {
        private readonly INlog _logger;
        IUserBL userBl;
        public UserController(IUserBL userBl,INlog logger)
        {
            this.userBl = userBl;
            this._logger = logger;
        }
        [HttpPost]
        public ActionResult AddUser(Users user)
        {
            try {
                 this.userBl.AddUser(user);
                 return this.Ok(new { success = true, message = "Registration Successful " });             
                }

            catch (Exception e)
            {
                return this.BadRequest(new { success = false, message = e.Message });
            }
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult LoginUser(EmailModle emailModel)
        {
            try
            {
                var token = this.userBl.Login(emailModel.Email, emailModel.Password);
                if (token == null)
                    return Unauthorized();
                return this.Ok(new { token = token, success = true, message = "Token Generated Successfull" });
                _logger.LogInfo("User Login.");
            }
            catch (Exception e)
            {
                _logger.LogError("User Login Fail.");
                return this.BadRequest(new { success = false, message = e.Message });
            }
        }
    }
}
