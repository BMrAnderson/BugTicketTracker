using Main.Data.Configurations;
using Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Main.Data
{
    public class TicketDBContext : DbContext
    {
        public TicketDBContext(DbContextOptions<TicketDBContext> options) : base (options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects { get; set; } 
    }
}
