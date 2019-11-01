using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PxxCore.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PxxCore.Repository.EFCore
{
    public class DbContextBase : DbContext
    {
        public DbContextBase(DbContextOptions<DbContextBase> options)
            : base(options)
        {
            //this.CreateDB();
        }

        public DbSet<Base_User> Base_User { get; set; }


        public void CreateDB()
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// QueryTrackingBehavior.NoTracking
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
