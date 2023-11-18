namespace GarageGroup.Infra;

public sealed record class OrchestrationEntitySignalIn<TIn>
{
    public OrchestrationEntitySignalIn(OrchestrationEntity entity, string operationName, TIn? value)
    {
        Entity = entity;
        OperationName = operationName ?? string.Empty;
        Value = value;
    }

    public OrchestrationEntity Entity { get; }

    public string OperationName { get; }

    public TIn? Value { get; }
}