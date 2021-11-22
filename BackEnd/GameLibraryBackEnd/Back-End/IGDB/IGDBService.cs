using IGDB;
using IGDB.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.IGDB
{
    public class IGDBService : IIGDBService
    {
        public IGDBClient Client { get; }

        public IGDBService(IOptions<IGDBConfig> igdbConfig)
        {
            Client = new IGDBClient(igdbConfig.Value.ClientId, igdbConfig.Value.ClientSecret);
        }

        public async Task<Game> testAsync(int id)
        {
            var games = await Client.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: $"fields id,name; where id ={id} ;");
            var game = games.First();

            Console.WriteLine(game.Name, game.Id);
            return game;
        }

        public async Task<Game[]> Games()
        {
            var games = await Client.QueryAsync<Game>(IGDBClient.Endpoints.Games);
          
            return games;
        }
    }
}
