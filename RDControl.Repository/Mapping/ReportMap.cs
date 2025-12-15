using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RDControl.Domain.Entities;

namespace RDControl.Repository.Mapping
{
    public class ReportMap : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            //checked
            builder.ToTable("Report");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Date)
                .IsRequired();
            builder.Property(prop => prop.Situation)
                .IsRequired();
            builder.Property(prop => prop.Description)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(prop => prop.Hours)
                .IsRequired()
                .HasPrecision(10, 2);
            builder.Property(prop => prop.Hours_price)
                .IsRequired()
                .HasPrecision(10, 2);
            builder.Property(prop => prop.Observation)
                .HasMaxLength(500);
            builder.Property(prop => prop.Ticket)
                .IsRequired()
                .HasMaxLength(1000);
            builder.Property(prop => prop.Payment);
            builder.HasOne(prop => prop.Equip);
            builder.HasOne(prop => prop._User);
            builder.HasOne(prop => prop._Technician);
        }
    }
}
