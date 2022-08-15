#nullable disable

namespace ContractsApp.Domain.Entities;

public class Contract : BaseAuditableEntity
{
    public Contract()
    {
        Customers = new HashSet<Customer>();
    }

    public string ContractCode { get; set; }
    public DateTime? DateOfLastPayment { get; set; }
    public DateTime? DateAccountOpened { get; set; }
    public decimal? OriginalAmount { get; set; }
    public int? OriginalAmountCurrencyId { get; set; }
    public decimal? InstallmentAmount { get; set; }
    public int? InstallmentAmountCurrencyId { get; set; }
    public decimal? OverdueBalance { get; set; }
    public int? OverdueBalanceCurrencyId { get; set; }
    public virtual Currency InstallmentAmountCurrency { get; set; }
    public virtual Currency OriginalAmountCurrency { get; set; }
    public virtual Currency OverdueBalanceCurrency { get; set; }
    public virtual ICollection<Customer> Customers { get; set; }
}