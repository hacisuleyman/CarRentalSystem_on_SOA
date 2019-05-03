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
    public class CarManager : ICarService, IDisposable
    {
        private IRepository<Car> _carDAL;

        public CarManager(IRepository<Car> carDAL)
        {
            _carDAL = carDAL;
        }

        public List<Car> GetAll()
        {
            return _carDAL.GetAll();
        }

        public Car Get(int carID)
        {
            return _carDAL.Get(carID);

        }

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(int carID)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            _carDAL.Update(entity);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
