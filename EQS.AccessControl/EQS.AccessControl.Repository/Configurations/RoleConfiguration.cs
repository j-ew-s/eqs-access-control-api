using EQS.AccessControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EQS.AccessControl.Repository.Configurations
{
    class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasIndex(h => h.Id);

            builder.Property(p => p.Name).IsRequired();

            builder.Ignore(i => i.Validations);
        }

    }
}
