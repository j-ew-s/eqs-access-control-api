using EQS.AccessControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EQS.AccessControl.Repository.Configurations
{
    class PersonRoleConfiguration : IEntityTypeConfiguration<PersonRole>
    {
        public void Configure(EntityTypeBuilder<PersonRole> builder)
        {
            builder.ToTable("PersonRoles");

            builder.HasKey(t => new { t.PersonId, t.RoleId });

            builder.HasOne(o => o.Roles)
                .WithMany(m => m.PersonRoles)
                .HasForeignKey(h => h.RoleId);
            builder.HasOne(o => o.Person)
                .WithMany(m => m.PersonRoles)
                .HasForeignKey(h => h.PersonId);
        }
    }

}

