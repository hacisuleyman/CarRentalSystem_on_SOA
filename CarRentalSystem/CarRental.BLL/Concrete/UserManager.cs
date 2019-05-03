using CarRental.DAL.Abstract;
using CarRental.Entities;
using CarRental.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BLL.Concrete
{
    public class UserManager : IUserService , IDisposable
    {
        private IRepository<User> _userDAL;

        public UserManager(IRepository<User> userDAL)
        {
            _userDAL = userDAL;
        }

        public void Add(User entity)
        {
            _userDAL.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public User Get(int id)
        {
            return _userDAL.Get(id);
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
