using ContractsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractsApp.Infrastructure.Persistence.Configurations;

public class IndividualConfiguration : IEntityTypeConfiguration<Individual>
{
    public void Configure(EntityTypeBuilder<Individual> entity)
    {
        entity.Property(e => e.Created)
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        entity.Property(e => e.CreatedBy).HasMaxLength(50);

        entity.Property(e => e.DateOfBirth).HasColumnType("date");

        entity.Property(e => e.LastModified).HasColumnType("datetime");

        entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

        entity.Property(e => e.Lastname)
            .IsRequired()
            .HasMaxLength(50);

        entity.Property(e => e.NationalId)
            .IsRequired()
            .HasMaxLength(10)
            .IsFixedLength();

        entity.Property(e => e.Surname)
            .IsRequired()
            .HasMaxLength(50);

        entity.HasOne(d => d.Gender)
            .WithMany(p => p.Individuals)
            .HasForeignKey(d => d.GenderId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Individuals_Genders");
    }
}

