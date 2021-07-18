using Microsoft.EntityFrameworkCore;
using Databases.RetrieverCore.Common.Models.Context;

namespace Databases.RetrieverCore.MasterDatabase.Context
{
    public class MasterDatabaseContext : RetrieverCoreContextBase
    {
        public MasterDatabaseContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DUCH003\\TOLEARNINSTANCE;Initial Catalog=FamilyTree;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
