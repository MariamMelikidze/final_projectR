using Microsoft.EntityFrameworkCore;
using Final_Project.Data.Models;

namespace Final_Project.Data
{
    public class FinalDbContext : DbContext
    {
        public FinalDbContext(DbContextOptions<FinalDbContext> options) : base(options)
        {
        }
        
        public DbSet<LoanUserModel> Loan { get; set; }
    }
}
