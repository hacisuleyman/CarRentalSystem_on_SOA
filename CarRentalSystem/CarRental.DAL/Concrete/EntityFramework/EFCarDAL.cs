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
    public class EFCarDAL : IRepository<Car> , IDisposable
    {
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (var _context = new DBContext())
            {
                try
                {
                    DbSet<Car> Table = _context.Set<Car>();
                    var oldCar = Table.FirstOrDefault(x => x.carID == entity.carID);
                    oldCar.rentalStatus = true;
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

        public Car Get(int carID)
        {
            using (var _context = new DBContext())
            {
                try
                {
                    DbSet<Car> Table = _context.Set<Car>();
                    return Table.Include(x => x.CarInformation).FirstOrDefault(c => c.carID == carID);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }

        public List<Car> GetAll()
        {
            using (var _context = new DBContext())
            {
                try
                {
                    DbSet<Car> Table = _context.Set<Car>();
                    return Table.Include(x => x.CarInformation).ToList();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}

