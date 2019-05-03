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
    public class RentalInfoManager : IRentalInfoService, IDisposable
    {
        private IRepository<RentalInformation> _rentalInfoDAL;

        public RentalInfoManager(IRepository<RentalInformation> rentalInfoDAL)
        {
            _rentalInfoDAL = rentalInfoDAL;
        }

        public void Add(RentalInformation entity)
        {
            _rentalInfoDAL.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public RentalInformation Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<RentalInformation> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(RentalInformation entity)
        {
            throw new NotImplementedException();
        }
    }
}
