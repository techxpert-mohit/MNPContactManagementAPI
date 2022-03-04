using Microsoft.EntityFrameworkCore;

namespace MNPContactManagementAPI.Controllers.Data
{
    public class DataContext:DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ContactDetails> ContactDetails { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
