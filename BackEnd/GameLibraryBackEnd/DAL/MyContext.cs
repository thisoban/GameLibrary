using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace DAL
{
    public class MyContext : DbContext, IDisposable
    {
         public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
    }
}
