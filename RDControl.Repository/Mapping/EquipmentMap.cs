using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RDControl.Domain.Entities;

namespace RDControl.Repository.Mapping
{
    public class EquipmentMap : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            //checked
            builder.ToTable("Equipment");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Model)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(prop => prop.Serial)
                .IsRequired()
                .HasMaxLength(30);
            builder.HasOne(prop => prop._Place);
        }
    }
}
