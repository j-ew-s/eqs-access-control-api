using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EQS.AccessControl.Repository.Context
{
    public class EntityFrameworkContext : DbContext
    {

        public EntityFrameworkContext(DbContextOptions<EntityFrameworkContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Role> Posts { get; set; }
        public DbSet<Credential> Credential { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new CredentialConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PersonRoleConfiguration());
        }

    }

}
