using Model;
using System;

namespace IDal
{
    public interface IUserDal
    {
        User Getuser(string username);

        void UpdateUser(User user);

        void DeleteUser(User user);

        void CreateUser(User user);
    }
}
