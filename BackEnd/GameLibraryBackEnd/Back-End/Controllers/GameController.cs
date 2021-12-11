using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Flurl;
using System.Threading.Tasks;
using IGDB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGDBService.IGDBService service = new IGDBService.IGDBService();
        // GET: api/<GameController>
        [HttpGet]
        public async Task<IEnumerable<IGDB.Models.Game>> Get()
        {
            var games = await service.GetGames();
            return games;
        }
        //public async Task<IEnumerable<IGDB.Models.Game>[]> Get()
        //{
        //   var games = await  service.GetGames();
        //    return (IEnumerable<IGDB.Models.Game>[])games;
        //}

        // GET api/<GameController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        //private static async Task<Game> GetGame(int id)
        //{
        //    return await $"";
        //}

        // POST api/<GameController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GameController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
