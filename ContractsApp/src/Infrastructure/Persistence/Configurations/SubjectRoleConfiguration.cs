using ContractsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractsApp.Infrastructure.Persistence.Configurations;

public class SubjectRoleConfiguration : IEntityTypeConfiguration<SubjectRole>
    {
        public void Configure(EntityTypeBuilder<SubjectRole> entity)
        {
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);

            entity.Property(e => e.GuaranteeAmount).HasColumnType("money");

            entity.Property(e => e.LastModified).HasColumnType("datetime");

            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.SubjectRoles)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_SubjectRoles_Customers");

            entity.HasOne(d => d.Role)
                .WithMany(p => p.SubjectRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_SubjectRoles_Roles");
        }

    }

