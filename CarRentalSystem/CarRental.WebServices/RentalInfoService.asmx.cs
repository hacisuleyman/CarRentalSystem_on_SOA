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
    /// Summary description for RentalInfoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RentalInfoService : System.Web.Services.WebService, IRentalInfoService
    {
        private RentalInfoManager _rentalInfoManager = new RentalInfoManager(new EFRentalInfoDAL());

        [WebMethod]
        public void Add(RentalInformation entity)
        {
            _rentalInfoManager.Add(entity);
        }

        [WebMethod]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public RentalInformation Get(int id)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<RentalInformation> GetAll()
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public void Update(RentalInformation entity)
        {
            throw new NotImplementedException();
        }
    }
}
