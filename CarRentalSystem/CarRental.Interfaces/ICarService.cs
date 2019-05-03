using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace CarRental.Interfaces
{
    public interface ICarService
    {
        void Add(Car entity);
        void Update(Car entity);
        void Delete(int id);
        Car Get(int id);
        List<Car> GetAll();
    }
}
