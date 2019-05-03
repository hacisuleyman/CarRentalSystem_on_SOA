using CarRental.DAL.Abstract;
using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Concrete.EntityFramework
{
    public class EFUserDAL : IRepository<User> , IDisposable
    {
        public void Add(User entity)
        {
            using (var _context = new DBContext())
            {
                try
                {
                    DbSet<User> Table = _context.Set<User>();
                    Table.Add(entity);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
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
            using (var _context = new DBContext())
            {
                try
                {
                    DbSet<User> Table = _context.Set<User>();
                    return Table.Include(x => x.UserInformation).FirstOrDefault(u => u.userID == id);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
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
