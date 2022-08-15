namespace ContractsApp.Domain.Events;

public class ContractCreatedEvent : BaseEvent
{
    public ContractCreatedEvent(Contract item)
    {
        Item = item;
    }

    public Contract Item { get; }
}