using Microsoft.EntityFrameworkCore;
using RetrieverCore.LocalDatabase.Models;
using System;
using System.Reflection;

namespace RetrieverCore.LocalDatabase
{ 
    public class LocalDatabaseContext : DbContext
    {
        public LocalDatabaseContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=LocalDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ComputerEntity>()
                .Property(x => x.Notes)
                .HasConversion(
                    x => string.Join(';', x),
                    x => x.Split(";", StringSplitOptions.RemoveEmptyEntries)
                );
        }

        public DbSet<ComputerEntity> Computers { get; set; }
        public DbSet<BatteryEntity> Batteries { get; set; }
        public DbSet<DDREntity> DDRs { get; set; }
        public DbSet<GPUEntity> GPUs { get; set; }
        public DbSet<MainboardEntity> Mainboards { get; set; }
        public DbSet<MainboardPortEntity> MainboardPorts { get; set; }
        public DbSet<NetworkInterfaceEntity> NetworkInterfaces { get; set; }
        public DbSet<ProcessorEntity> Processors { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
    }
}
