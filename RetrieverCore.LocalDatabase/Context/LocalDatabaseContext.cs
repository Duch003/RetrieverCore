using Microsoft.EntityFrameworkCore;
using RetrieverCore.Common.Context;
using System.Reflection;

namespace RetrieverCore.LocalDatabase
{ 
    public class LocalDatabaseContext : RetrieverCoreContextBase
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
    }
}
