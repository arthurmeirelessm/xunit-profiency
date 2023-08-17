using Microsoft.EntityFrameworkCore;
using XUnit_proficiency.Models;

namespace XUnit_proficiency.PostgresService
{
    public class ConnectionPostgres : DbContext
    {
        public DbSet<Payer> payers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=PostgreSQL 15;" + 
                "Port=5432;Database=payers;" +
                "User Id=postgres;" +
                "Password=msesjdfdn1!"
                );
    }
}
