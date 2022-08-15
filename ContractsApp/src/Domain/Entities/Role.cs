namespace ContractsApp.Domain.Entities;

public class BusinessRole : BaseAuditableEntity
{
    public BusinessRole()
    {
        SubjectRoles = new HashSet<SubjectRole>();
    }

    public string Name { get; set; }

    public ICollection<SubjectRole> SubjectRoles { get; set; }
}