using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithOnion.models.Repository
{
    internal interface IRepository<T> : IDisposable where T : class
    {
        void Create(T entity);
        void  Update(int id ,T entity);
        Task<bool> Delete(int id);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        void save();
    }
}
