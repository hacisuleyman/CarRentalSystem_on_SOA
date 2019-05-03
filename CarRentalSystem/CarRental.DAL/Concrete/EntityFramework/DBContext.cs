using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Concrete.EntityFramework
{
    public class DBContext:DbContext
    {
        public DBContext():
           base(@"metadata=res://*/CarRentalDB.csdl|res://*/CarRentalDB.ssdl|res://*/CarRentalDB.msl;provider=System.Data.SqlClient;provider connection string=';data source=.;initial catalog=CarRentalDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot';")
        {
        }
    }
}
