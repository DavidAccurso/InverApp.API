using InversiApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InversiApp.API.Repository.EF
{
    public class InvestmentsContext : DbContext
    {
        public InvestmentsContext(DbContextOptions<InvestmentsContext> options) : base(options) { }

        public DbSet<Investment> Investments { get; set; }
    }
}
