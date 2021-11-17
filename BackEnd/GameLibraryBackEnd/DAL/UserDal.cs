using IDal;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDal : IUserDal
    {
        private readonly IMyContext _context;
        public UserDal(IMyContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public User GetUser(int id)
        {
            User user = new User();
          
            try
            {
               user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return user;
        }

        public User GetuserByName(string username)
        {
            User user = new User();
            try
            {
                user = _context.Users.Include("favourites").Where(x => x.UserName == username).FirstOrDefault();
            }
            catch
            {
              throw;
            }
             return user;
        }

        public void UpdateUser(User user)
        {
            User DbUser = _context.Users.Include("Favourite").Where(x => x.UserName == user.UserName).FirstOrDefault();
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
              throw;
            }
        }
        public void DeleteUser(User user)
        {
            User dbuser = _context.Users.Include("Favourite").Where(x => x.UserName == x.UserName).FirstOrDefault();
            try
            {
                _context.Users.Remove(dbuser);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }  
        }
    }
}
