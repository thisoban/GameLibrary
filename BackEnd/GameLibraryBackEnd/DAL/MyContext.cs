using IDal;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Linq;

namespace DAL
{
    public class MyContext : DbContext, IMyContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }

        public MyContext(DbContextOptions options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);
    }
}
