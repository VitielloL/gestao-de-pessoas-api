using GestaoPessoasApi.Models.Pessoa;
using Microsoft.EntityFrameworkCore;

namespace GestaoPessoasApi.Data
{
    public class AppDbContext : DbContext
    {
        // Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
        //Server=DESKTOP-OTI3SH0;Database=api_dotnet_test;Trusted_Connection=True;

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OTI3SH0;Database=api_dotnet_test;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
