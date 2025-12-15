using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RDControl.Domain.Entities;

namespace RDControl.Repository.Mapping
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            //checked
            builder.ToTable("Client");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasIndex(prop => prop.CNPJ).IsUnique();
            builder.Property(prop => prop.CNPJ)
                .IsRequired()
                .HasMaxLength(18 );
        }
    }
}
