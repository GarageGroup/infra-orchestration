using System;

namespace GarageGroup.Infra;

public sealed record class OrchestrationInstanceScheduleIn<TIn>
{
    public OrchestrationInstanceScheduleIn(string orchestratorName, TIn? value)
    {
        OrchestratorName = orchestratorName ?? string.Empty;
        Value = value;
    }

    public string OrchestratorName { get; }

    public TIn? Value { get; }

    public string? InstanceId { get; init; }

    public DateTimeOffset? StartAt { get; init; }
}