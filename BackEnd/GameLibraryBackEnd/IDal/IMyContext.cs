using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal
{
    public interface IMyContext :IDisposable
    {
        DbSet<User> Users { get; set; }
       DbSet<Favourite> Favourites { get; set; }

        int SaveChanges();
    }
}
