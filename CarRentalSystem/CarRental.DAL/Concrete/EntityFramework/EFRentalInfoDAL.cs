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
    public class EFRentalInfoDAL : IRepository<RentalInformation>,IDisposable
    {
        public void Add(RentalInformation entity)
        {
            using (var _context = new DBContext())
            {
                try
                {
                    DbSet<RentalInformation> Table = _context.Set<RentalInformation>();
                    var newRentalInfo = entity;
                    Table.Add(newRentalInfo);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }

        public void Update(RentalInformation entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public RentalInformation Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<RentalInformation> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
