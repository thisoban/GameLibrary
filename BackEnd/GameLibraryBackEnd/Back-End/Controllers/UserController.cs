using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.Controllers
{   [ApiController]
    public class UserController : Controller
    {
        // get user
        
        //show user details

        //edit user details

        // 
        [HttpGet]
        [Route("UserDetails")]
        public User Get()
        {//get logic user
            User user = new User();
            return user;
        }
    }
}
