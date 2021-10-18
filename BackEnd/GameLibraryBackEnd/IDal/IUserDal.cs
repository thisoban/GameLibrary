using Model;
using System;

namespace IDal
{
    public interface IUserDal
    {
        User GetuserByName(string username);

        User GetUser(int id);
        void UpdateUser(User user);

        void DeleteUser(User user);

        void CreateUser(User user);
    }
}
