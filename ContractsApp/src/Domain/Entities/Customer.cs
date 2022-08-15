namespace ContractsApp.Domain.Entities;

public class Customer : BaseAuditableEntity
{
    public Customer()
    {
        SubjectRoles = new HashSet<SubjectRole>();
    }

    public string CustomerCode { get; set; }
    public int? IndividualId { get; set; }
    public int? ContractId { get; set; }
    public Contract Contract { get; set; }
    public Individual Individual { get; set; }
    public ICollection<SubjectRole> SubjectRoles { get; set; }
}