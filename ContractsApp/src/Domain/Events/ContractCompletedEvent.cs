namespace ContractsApp.Domain.Events;

public class ContractCompletedEvent : BaseEvent
{
    public ContractCompletedEvent(Contract item)
    {
        Item = item;
    }

    public Contract Item { get; }
}