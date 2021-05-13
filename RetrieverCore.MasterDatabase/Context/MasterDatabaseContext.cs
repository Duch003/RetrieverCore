using Microsoft.EntityFrameworkCore;
using RetrieverCore.Common.Context;

namespace RetrieverCore.MasterDatabase.Context
{
    public class MasterDatabaseContext : RetrieverCoreContextBase
    {
        public MasterDatabaseContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DUCH003\\TOLEARNINSTANCE;Initial Catalog=WmiResults;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
