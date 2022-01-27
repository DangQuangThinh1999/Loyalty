using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.EF
{
    public class LoyaltyDBContextFactory : IDesignTimeDbContextFactory<LoyaltyDBContext>
    {
        public LoyaltyDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json") // Lấy thư mục hiện tại là appsettings.json
                 .Build();
            // tạo biến kết nối kết nối database( value : LoyaltyDb là tên nằm ở file appsettings.json)
            var connectionString = configuration.GetConnectionString("LoyaltyDb");

            var optionsBuilder = new DbContextOptionsBuilder<LoyaltyDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new LoyaltyDBContext(optionsBuilder.Options);
        }
    }
}