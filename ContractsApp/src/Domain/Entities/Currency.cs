
namespace ContractsApp.Domain.Entities;

public class Currency : BaseAuditableEntity
{
    public Currency()
    {
        ContractInstallmentAmountCurrencies = new HashSet<Contract>();
        ContractOriginalAmountCurrencies = new HashSet<Contract>();
        ContractOverdueBalanceCurrencies = new HashSet<Contract>();
    }

    public string CurrencyCode { get; set; }
    public ICollection<Contract> ContractInstallmentAmountCurrencies { get; set; }
    public ICollection<Contract> ContractOriginalAmountCurrencies { get; set; }
    public ICollection<Contract> ContractOverdueBalanceCurrencies { get; set; }
}