using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mypos.Domain.Entities;

namespace Mypos.Data.Mappings
{
    public class TelefoneMap : IEntityTypeConfiguration<TelefoneEntity>
    {
        public void Configure(EntityTypeBuilder<TelefoneEntity> builder)
        {
            builder.ToTable("Telefone");

            builder.HasKey(t => t.Id);


            builder.Property(t => t.Numero)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(t => t.Tipo)
                .IsRequired();

            builder.HasOne(t => t.Cliente)
                .WithMany(p => p.Telefones)
                .HasForeignKey(t => t.ClienteId);
        }
    }
}
