namespace ContractsApp.Domain.Entities;

public class Gender : BaseAuditableEntity
{
    public Gender()
    {
        Individuals = new HashSet<Individual>();
    }

    public string Name { get; set; }
    public ICollection<Individual> Individuals { get; set; }
}