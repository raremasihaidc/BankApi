using BankAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BankAPI.Data
{
    public class BankDbContext :DbContext
    { public BankDbContext(DbContextOptions<BankDbContext> options) : base(options) { }
        public DbSet<Bank> Banks { get; set; }
    }
}
