using ContractsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContractsApp.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Contract> Contracts { get; }
    DbSet<Currency> Currencies { get; }
    DbSet<Customer> Customers { get; }
    DbSet<Gender> Genders { get; }
    DbSet<Individual> Individuals { get; }
    DbSet<BusinessRole> BusinessRoles { get; }
    DbSet<SubjectRole> SubjectRoles { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}