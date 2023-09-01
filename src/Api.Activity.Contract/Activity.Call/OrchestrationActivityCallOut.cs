namespace GarageGroup.Infra;

public sealed record class OrchestrationActivityCallOut<TOut>
{
    public OrchestrationActivityCallOut(TOut? value)
        =>
        Value = value;

    public TOut? Value { get; }
}