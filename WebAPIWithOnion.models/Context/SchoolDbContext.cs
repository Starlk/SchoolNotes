using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIWithOnion.models.Entity;

namespace WebApiWithOnion.models.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> option ) : base(option)
        {
    
        }

        public DbSet<Estudent> estudents { get; set; }
        public DbSet<Note> notes { get; set; }


        public DbSet<T> GetDbSet<T>() where T : class =>Set<T>();
        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    builder.UseSqlServer(_conf.GetConnectionString("defaultdConnection"));
        //}
     
    }
}
