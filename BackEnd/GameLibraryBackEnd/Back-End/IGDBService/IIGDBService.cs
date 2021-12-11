using IGDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.IGDBService
{
    public interface IIGDBService
    {
        IGDBClient Client { get; }
    }
}
