using BankSsyNet.Server.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace BankSsyNet.Server.Data
{
    public class BankingDbContext: DbContext
    {
        public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customer { get; set; }
    }
}
