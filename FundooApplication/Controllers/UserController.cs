using BussinessLayer;
using CommonLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult SampleUserApi(User user)
        {
            try {
                bool res = this.userBl.SampleUserApi(user);
                if (res == true)
                {
                    return this.Ok(new { success = true, message = "Registration Successful " });
                }
                else
                {
                    return this.Ok(new { success = false, message = "Registration UnSuccessful " });
                }
                }

            catch (Exception e)
            {
                return this.BadRequest(new { success = false, message = e.Message });
            }
        }

    }
}
