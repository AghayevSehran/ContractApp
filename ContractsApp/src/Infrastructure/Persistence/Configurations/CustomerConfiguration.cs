using ContractsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractsApp.Infrastructure.Persistence.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
        entity.Property(e => e.Created).HasColumnType("datetime");

        entity.Property(e => e.CreatedBy).HasMaxLength(50);

        entity.Property(e => e.CustomerCode)
            .HasMaxLength(10)
            .IsFixedLength();

        entity.Property(e => e.LastModified).HasColumnType("datetime");

        entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

        entity.HasOne(d => d.Contract)
            .WithMany(p => p.Customers)
            .HasForeignKey(d => d.ContractId)
            .HasConstraintName("FK_Customers_Contracts");

        entity.HasOne(d => d.Individual)
            .WithMany(p => p.Customers)
            .HasForeignKey(d => d.IndividualId)
            .HasConstraintName("FK_Customers_Individuals");
    }

    }

