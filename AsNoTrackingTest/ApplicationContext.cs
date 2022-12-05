using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsNoTrackingTest.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AsNoTrackingTest
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Satislar> Satislar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
            IConfiguration configuration = configBuilder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
        }
    }
}


