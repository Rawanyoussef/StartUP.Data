using Microsoft.EntityFrameworkCore;
using StartUP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StartUP.Data.Context
{
    public class StartUPContext : DbContext
    {
        public StartUPContext(DbContextOptions<StartUPContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

        }
        public  DbSet<User> Users { get; set; }
    }
}
