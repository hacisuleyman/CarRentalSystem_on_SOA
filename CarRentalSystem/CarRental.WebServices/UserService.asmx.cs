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
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService , IUserService
    {
        private UserManager _userManager = new UserManager(new EFUserDAL());

        [WebMethod]
        public void Add(User entity)
        {
            _userManager.Add(entity);
        }

        [WebMethod]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public User Get(int id)
        {
            return _userManager.Get(id);
        }

        [WebMethod]
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
