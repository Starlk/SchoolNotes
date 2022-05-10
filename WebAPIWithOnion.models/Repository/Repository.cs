using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithOnion.core.Base.Base;
using WebApiWithOnion.models.Context;

namespace WebApiWithOnion.models.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private SchoolDbContext _context;
        private DbSet<T> _dbSet;
        public Repository(SchoolDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void create(T entity)
        {

            _dbSet.Add(entity);
            _context.SaveChanges();
            
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void getAll()
        {
            throw new NotImplementedException();
        }

        public T getOne(int id)
        {
            
            return null;
        }

        public void update(int id, T entity)
        {
            throw new NotImplementedException();
        }

  


    }
}
