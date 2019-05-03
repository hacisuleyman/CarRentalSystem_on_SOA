using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Interfaces
{
    public interface IRentalInfoService
    {
        void Add(RentalInformation entity);
        void Update(RentalInformation entity);
        void Delete(int id);
        RentalInformation Get(int id);
        List<RentalInformation> GetAll();
    }
}
