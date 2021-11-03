using IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class GameDal
    {
        private readonly IMyContext _context;
        public GameDal(IMyContext context)
        {
            _context = context;
        }


    }
}
