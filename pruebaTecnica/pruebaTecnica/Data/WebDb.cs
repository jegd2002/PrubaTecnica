using Microsoft.EntityFrameworkCore;
using pruebaTecnica.Models;

namespace pruebaTecnica.Data

{
    public class WebDb : DbContext
    {
        public WebDb(DbContextOptions<WebDb> options) : base(options)
        {

        }
        public DbSet<productos> productos => Set<productos>();
    }
}
