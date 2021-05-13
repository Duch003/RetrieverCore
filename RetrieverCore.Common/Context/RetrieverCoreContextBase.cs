using Microsoft.EntityFrameworkCore;
using RetrieverCore.Common.Models;

namespace RetrieverCore.Common.Context
{
    public class RetrieverCoreContextBase : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<DDR> DDRs { get; set; }
        public DbSet<Mainboard> Mainboards { get; set; }
        public DbSet<NetworkInterface> NetworkInterfaces { get; set; }
        public DbSet<Partition> Partitions { get; set; }
        public DbSet<Storage> Storages { get; set; }
    }
}

