namespace ContractsApp.Domain.Entities;

public class SubjectRole : BaseAuditableEntity
{
    public int? CustomerId { get; set; }
    public int? RoleId { get; set; }
    public decimal? GuaranteeAmount { get; set; }
    public Customer Customer { get; set; }
    public BusinessRole Role { get; set; }
}