using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RDControl.Domain.Entities;

namespace RDControl.Repository.Mapping
{
    public class PlaceMap : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            //checked
            builder.ToTable("Place");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Pname)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(prop => prop.Address)
                .HasMaxLength(100);
            builder.HasOne(prop => prop._Client);
        }
    }
}
