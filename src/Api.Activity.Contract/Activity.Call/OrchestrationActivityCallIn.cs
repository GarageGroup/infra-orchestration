namespace GarageGroup.Infra;

public sealed record class OrchestrationActivityCallIn<TIn>
{
    public OrchestrationActivityCallIn(string activityName, TIn? value)
    {
        ActivityName = activityName ?? string.Empty;
        Value = value;
    }

    public string ActivityName { get; }

    public TIn? Value { get; }
}