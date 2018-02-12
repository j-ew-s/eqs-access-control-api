using EQS.AccessControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EQS.AccessControl.Repository.Context
{
    public class EntityFrameworkContext : DbContext
    {

        public EntityFrameworkContext(DbContextOptions<EntityFrameworkContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Role> Posts { get; set; }
        public DbSet<Credential> Credential { get; set; }
    }

}
