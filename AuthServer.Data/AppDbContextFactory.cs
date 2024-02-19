using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AuthServer.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer("server=localhost;database=NetToken;user id=SA;password=reallyStrongPwd123;multipleactiveresultsets=true;trustservercertificate=true;trusted_Connection=False;");

            return new AppDbContext(optionsBuilder.Options);

        }
    }
}

