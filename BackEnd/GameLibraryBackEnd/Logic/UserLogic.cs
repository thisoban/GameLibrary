using ILogic;
using System;
using Model;
using IDal;


namespace Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDal _iDal;

        public UserLogic(IUserDal iDal)
        {
            _iDal = iDal;
        }

        public bool CheckUserValid(User user)
        {
            User Getuser = _iDal.GetuserByName(user.UserName);
            if (user.UserName == Getuser.UserName && user.password == Getuser.password)
            {
                return true;
            }
            return false;
        }

        public void CreateUser(User user)
        {
            _iDal.CreateUser(user);
        }

        public User GetUserById(int id)
        {
           User user = _iDal.GetUser(id);

            return user;
        }

        public void RemoveUser(User user)
        {

            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            User getuser = _iDal.GetUser(user.Id);
            if(getuser.Id == user.Id )
            {
                _iDal.UpdateUser(user);
                //user correct update
            }
            throw new NotImplementedException();
        }
        public User GetUserByName(User user)
        {
            User userbyname = _iDal.GetuserByName(user.UserName);
            return userbyname;
        }

        public void deleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
