using Main.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Configurations
{
    public class ProjectEntityTypeConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasMany(p => p.Bugs).WithOne(b => b.AssignedProject).HasForeignKey(s => s.AssignedProjectId);

            builder.HasMany(p => p.MembersAssigned).WithMany(m => m.ProjectsAssigned);
        }
    }
}