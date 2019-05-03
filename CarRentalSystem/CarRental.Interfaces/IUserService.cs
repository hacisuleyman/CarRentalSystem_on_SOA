using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Interfaces
{
    public interface IUserService
    {
        void Add(User entity);
        void Update(User entity);
        void Delete(int id);
        User Get(int id);
        List<User> GetAll();
    }
}
