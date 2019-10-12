using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PxxCore.Repository.EFCore
{
    public class DbContextBase : DbContext
    {
        public DbContextBase()
        {
            this.CreateDB();
        }

        public void CreateDB()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfiguration configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json").Build();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
