using IGDB;
using IGDB.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.IGDBService
{
    public class IGDBService : IIGDBService
    {
        public IGDBClient Client { get; }

        public IGDBService()
        {
            Client = new IGDBClient("dtyf1m6sh84pvfxpml37o5nv9ybapy", "veeb1lzntrosmmk0fzg93y90cn12xi");
        }

        public async Task<Game> GetGame(int id)
        {
            var games = await Client.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: $"fields *; where id ={id} ;");
            
            var game = games.First();

            Console.WriteLine(game.Name, game.Id);
            return game;
        }

        public async Task<Game[]> GetGames()
        {
            var games = await Client.QueryAsync<Game>(IGDBClient.Endpoints.Games, query : $"fields * ;"); ;
          
            return games;
        }
    }
}
