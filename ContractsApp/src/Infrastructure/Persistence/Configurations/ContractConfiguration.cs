using ContractsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractsApp.Infrastructure.Persistence.Configurations;

public class ContractConfiguration : IEntityTypeConfiguration<Contract>
{
    public void Configure(EntityTypeBuilder<Contract> entity)
    {
        entity.Property(e => e.ContractCode)
            .IsRequired()
            .HasMaxLength(10)
            .IsFixedLength();

        entity.Property(e => e.Created)
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        entity.Property(e => e.CreatedBy).HasMaxLength(50);

        entity.Property(e => e.DateAccountOpened).HasColumnType("datetime");

        entity.Property(e => e.DateOfLastPayment).HasColumnType("datetime");

        entity.Property(e => e.InstallmentAmount).HasColumnType("money");

        entity.Property(e => e.LastModified).HasColumnType("datetime");

        entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

        entity.Property(e => e.OriginalAmount).HasColumnType("money");

        entity.Property(e => e.OverdueBalance).HasColumnType("money");

        entity.HasOne(d => d.InstallmentAmountCurrency)
            .WithMany(p => p.ContractInstallmentAmountCurrencies)
            .HasForeignKey(d => d.InstallmentAmountCurrencyId)
            .HasConstraintName("FK_Contracts_Currencies4");

        entity.HasOne(d => d.OriginalAmountCurrency)
            .WithMany(p => p.ContractOriginalAmountCurrencies)
            .HasForeignKey(d => d.OriginalAmountCurrencyId)
            .HasConstraintName("FK_Contracts_Currencies3");

        entity.HasOne(d => d.OverdueBalanceCurrency)
            .WithMany(p => p.ContractOverdueBalanceCurrencies)
            .HasForeignKey(d => d.OverdueBalanceCurrencyId)
            .HasConstraintName("FK_Contracts_Currencies5");
    }
   }