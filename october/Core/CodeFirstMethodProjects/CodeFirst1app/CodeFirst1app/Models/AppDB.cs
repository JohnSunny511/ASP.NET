using Microsoft.EntityFrameworkCore;
using CodeFirst1app.Models;
namespace CodeFirst1app.Models
{
    public class AppDB : DbContext //db Create  Dbcontext is class used to create table
    {
        public AppDB(DbContextOptions<AppDB> options) : base(options)         // base keyword is used to take the functions of the base class (DbContext)
        {

        }

        public DbSet<Category> categories { get; set; }   // Its used to create Tabel with the name Category
        public DbSet<Product> products { get; set; }
    }
}
