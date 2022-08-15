namespace ContractsApp.Domain.Events;

public class ContractDeletedEvent : BaseEvent
{
    public ContractDeletedEvent(Contract item)
    {
        Item = item;
    }

    public Contract Item { get; }
}