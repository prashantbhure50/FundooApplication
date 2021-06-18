﻿using BussinessLayer;
using CommonLayer;
using CommonLayer.DataBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBL userBl;
        public UserController(IUserBL userBl)
        {
            this.userBl = userBl;
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
        [HttpPost("login")]
        public IActionResult Login(EmailModle user)
        {
            var token = this.userBl.AuthenticateUser(user.Email);
            return Ok();
        }

        


    }
}
