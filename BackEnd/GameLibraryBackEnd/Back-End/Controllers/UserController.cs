using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ILogic;

namespace Back_End.Controllers
{   [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserLogic _userLogic;
        public UserController(IUserLogic userlogic)
        {
            _userLogic = userlogic;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            
            return new string[] { "value1", "value2" };
        }
       
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user = _userLogic.GetUserById(id);

            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post( User value)
        {
            _userLogic.CreateUser(value);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, User user)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
