using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        TEntity Get(int id);
        List<TEntity> GetAll();
    }
}
