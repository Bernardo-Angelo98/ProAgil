using Microsoft.EntityFrameworkCore;
using ProAgil.Models;

namespace ProAgil.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        
        public DbSet<Event> Events { get; set; }
    }
}