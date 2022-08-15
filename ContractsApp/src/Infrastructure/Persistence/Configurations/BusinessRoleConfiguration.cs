using ContractsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractsApp.Infrastructure.Persistence.Configurations;

public class BusinessRoleConfiguration : IEntityTypeConfiguration<BusinessRole>
{
    public void Configure(EntityTypeBuilder<BusinessRole> entity)
    {
        entity.Property(e => e.Created)
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        entity.Property(e => e.CreatedBy).HasMaxLength(50);

        entity.Property(e => e.LastModified).HasColumnType("datetime");

        entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

        entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(45);
    }
}
