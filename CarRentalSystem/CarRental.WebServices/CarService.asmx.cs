using CarRental.BLL.Concrete;
using CarRental.DAL.Concrete.EntityFramework;
using CarRental.Entities;
using CarRental.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CarRental.WebServices
{
    /// <summary>
    /// Summary description for CarService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarService : System.Web.Services.WebService, ICarService
    {
        private CarManager _carManager = new CarManager(new EFCarDAL());

        [WebMethod]
        public List<Car> GetAll()
        {
            return _carManager.GetAll();
        }

        [WebMethod]
        public Car Get(int carID)
        {
            return _carManager.Get(carID);
        }

        [WebMethod]
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public void Delete(int carID)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public void Update(Car entity)
        {
            _carManager.Update(entity);
        }
    }
}
