using Microsoft.EntityFrameworkCore;
using Mypos.Data.Mappings;
using Mypos.Domain.Entities;

namespace Mypos.Data.Context
{
    public class MyposContext : DbContext
    {
        public DbSet<ClienteEntity> MyProperty { get; set; }
        public MyposContext(DbContextOptions<MyposContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClienteEntity>(new ClienteMap().Configure);
            modelBuilder.Entity<EmailEntity>(new EmailMap().Configure);
            modelBuilder.Entity<TelefoneEntity>(new TelefoneMap().Configure);
            modelBuilder.Entity<EnderecoEntity>(new EnderecoMap().Configure);
        }
    }
}
