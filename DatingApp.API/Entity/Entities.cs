using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;

namespace DatingApp.API.Entity
{
    public class Entities : DbContext
    {
        public Entities(DbContextOptions<Entities> options) : base (options) {      
        }
        public DbSet<Value> Values { get; set; }
    }
}