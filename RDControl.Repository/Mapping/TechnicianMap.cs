using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RDControl.Domain.Entities;

namespace RDControl.Repository.Mapping
{
    public class TechnicianMap : IEntityTypeConfiguration<Technician>
    {
        public void Configure(EntityTypeBuilder<Technician> builder)
        {
            //checked
            builder.ToTable("Technician");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasIndex(prop => prop.CPF).IsUnique();
            builder.Property(prop => prop.CPF)
                .IsRequired()
                .HasMaxLength(14);
            builder.Property(prop => prop.TechType)
                .IsRequired();
        }
    }
}
