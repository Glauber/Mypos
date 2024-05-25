using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mypos.Domain.Entities;

public class EnderecoMap : IEntityTypeConfiguration<EnderecoEntity>
{
    public void Configure(EntityTypeBuilder<EnderecoEntity> builder)
    {
        builder.ToTable("Endereco");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Logradouro)
            .IsRequired()
            .HasMaxLength(128);

        builder.Property(e => e.Numero)
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(e => e.Complemento)
            .HasMaxLength(128);

        builder.Property(e => e.Bairro)
            .IsRequired()
            .HasMaxLength(64);
        
        builder.Property(e => e.Cidade)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(e => e.Estado)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(e => e.Cep)
            .IsRequired()
            .HasMaxLength(11);

        builder.HasOne(e => e.Cliente)
            .WithMany(c => c.Enderecos)
            .HasForeignKey(e => e.ClienteId);
    }
}