using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mypos.Domain.Entities;

namespace Mypos.Data.Mappings
{
    public class EmailMap : IEntityTypeConfiguration<EmailEntity>
    {
        public void Configure(EntityTypeBuilder<EmailEntity> builder)
        {
            builder.ToTable("Email");
            
            builder.HasKey(e => e.Id);

            builder.Property(e => e.EnderecoEmail)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.Principal)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
