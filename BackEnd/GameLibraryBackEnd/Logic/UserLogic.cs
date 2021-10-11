using ILogic;
using System;
using Model;

namespace Logic
{
    public class UserLogic : IUserLogic
    {

       public User GetUser(User userModel)
        {
            User user = new User();

            if (userModel.UserName == user.UserName && userModel.password == user.password) 
            { 

            }

            return user;
        }
    }
}
