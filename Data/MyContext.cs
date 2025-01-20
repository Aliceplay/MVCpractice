using Microsoft.EntityFrameworkCore;
using MVCpractice.Models;

namespace MVCpractice.Data
{//proprate and mathed / context to project and database.
    public class MyContext :DbContext
    {
        
        public MyContext(DbContextOptions<MyContext>options):base(options) { }
        public DbSet<Item>items { get; set; }
    }
}
