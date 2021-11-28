using Microsoft.EntityFrameworkCore;
using MysqlConection.Models;

namespace MysqlConection.Data
{
    public class DataContext : DbContext
    {
        public  DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<Pessoa> pessoa {get; set;}
    }
}