using EQS.AccessControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EQS.AccessControl.Repository.Configurations
{
    class CredentialConfiguration : IEntityTypeConfiguration<Credential>
    {
        public void Configure(EntityTypeBuilder<Credential> builder)
        {
            builder.ToTable("Credentials");

            builder.HasKey(k => k.Id);

            builder.HasOne(h => h.Person).WithOne(w => w.Credential).HasForeignKey<Person>(h => h.Id);

            builder.Property(p => p.Password).IsRequired();

            builder.Property(p => p.Username).IsRequired();

            builder.Ignore(i => i.Validations);
        }

    }
}
