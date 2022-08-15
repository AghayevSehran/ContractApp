namespace ContractsApp.Domain.Entities;

public class Individual : BaseAuditableEntity
{
    public Individual()
    {
        Customers = new HashSet<Customer>();
    }

    public string Surname { get; set; }
    public string Lastname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int GenderId { get; set; }
    public string NationalId { get; set; }
    public virtual Gender Gender { get; set; }
    public virtual ICollection<Customer> Customers { get; set; }
}