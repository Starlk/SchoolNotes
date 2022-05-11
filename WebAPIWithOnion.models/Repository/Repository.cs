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
            _dbSet= context.GetDbSet<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            
             
        }
        public async void save() 
        {
           await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            T entity = await GetById(id);
            if (entity == null) return false;
            _dbSet.Remove(entity);
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();

        }

        public async Task<T> GetById(int id)
        {
            var datos =  await _dbSet.FindAsync(id);
            return datos;
        }

        public async void Update(int id, T entity)
        {
            if (await Delete(id)) _dbSet.Add(entity);
        }
    }
}
