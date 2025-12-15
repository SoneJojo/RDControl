using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RDControl.Domain.Entities;

namespace RDControl.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //checked
            builder.ToTable("User");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasIndex(prop => prop.Email).IsUnique();
            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(prop => prop.Login).IsUnique();
            builder.Property(prop => prop.Login)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(prop => prop.Password)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.RegisterDate);
        }
    }
}
