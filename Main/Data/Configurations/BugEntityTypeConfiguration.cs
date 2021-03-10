using Main.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Configurations
{
    public class BugEntityTypeConfiguration : IEntityTypeConfiguration<Bug>
    {
        public void Configure(EntityTypeBuilder<Bug> builder)
        {
            builder.HasOne(b => b.AssignedMember).WithMany(m => m.BugsAssigned).HasForeignKey(s => s.AssignedMemberId);
           
            builder.HasOne(b => b.AssignedProject).WithMany(p => p.Bugs).HasForeignKey(s => s.AssignedProjectId);

            //builder.HasData(EntitySeed.Bugs);

            //builder.OwnsOne(p => p.AssignedProject).HasData(EntitySeed.Projects.First());

            //builder.OwnsOne(p => p.AssignedMember).HasData(EntitySeed.Members.First());
        }
    }
}
