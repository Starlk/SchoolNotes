using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithOnion.models.Repository
{
    internal interface IRepository<T> : IDisposable where T : class
    {
        void create(T entity);
        void update(int id, T entity);
        void delete(int id);
        T getOne(int id);

        void getAll();
        
    }
}
