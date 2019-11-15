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

        /// <summary>
        /// CodeFirst  模型创建或更新
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSet Model
        public DbSet<Base_User> Base_User { get; set; }

        public DbSet<Base_Department> Base_Department { get; set; }

        public DbSet<Base_SysLog> Base_SysLog { get; set; }
        #endregion
    }
}
