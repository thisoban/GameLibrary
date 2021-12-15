using IGDB.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.IGDBService
{
    public class api : IGDB.IGDBApi
    {
        public string ClientId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<CountResponse> CountAsync([Path] string endpoint, [Body] string query = null)
        {
            throw new NotImplementedException();
        }

        public Task<T[]> QueryAsync<T>([Path] string endpoint, [Body] string query = null)
        { 
            
                throw new NotImplementedException();
        }
    }
}
