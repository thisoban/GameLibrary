using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }

        public virtual List<Favourite> Favourites { get; set; }
        
    }
}
