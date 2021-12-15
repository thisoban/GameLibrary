using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ILogic
{
    public interface IUserLogic
    {
        User GetUserById(int id);
        bool CheckUserValid(User user);
        void UpdateUser(User user);
        void RemoveUser(User user);
        void CreateUser(User user);
        User GetUserByName(User user);
        void deleteUser(int id);
    }
}
