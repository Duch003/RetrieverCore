﻿using Microsoft.EntityFrameworkCore;
using Databases.RetrieverCore.Common.Models.Context;
using System.Reflection;

namespace Databases.RetrieverCore.LocalDatabase.Context
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
