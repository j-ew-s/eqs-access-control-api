using EQS.AccessControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EQS.AccessControl.Repository.Configurations
{
    class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("People");

            builder.HasKey(h => h.Id);

            builder.HasIndex(u => u.Id).IsUnique();

            builder.HasOne(h => h.Credential).WithOne(o => o.Person).HasForeignKey<Credential>(f => f.Id);

            builder.Property(p => p.Name).IsRequired();

            builder.Ignore(i => i.Validations);
        }

    }
}
