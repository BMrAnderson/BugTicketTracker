using Main.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Configurations
{
    public class MemberEntityTypeConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasMany(m => m.ProjectsAssigned).WithMany(p => p.MembersAssigned);

            builder.HasMany(m => m.BugsAssigned).WithOne(b => b.AssignedMember).HasForeignKey(s => s.AssignedMemberId);
        }
    }
}
