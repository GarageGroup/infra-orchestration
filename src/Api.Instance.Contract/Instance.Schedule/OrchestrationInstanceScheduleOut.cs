namespace GarageGroup.Infra;

public sealed record class OrchestrationInstanceScheduleOut
{
    public OrchestrationInstanceScheduleOut(IOrchestrationInstanceId instanceId)
        =>
        InstanceId = instanceId;

    public IOrchestrationInstanceId InstanceId { get; }
}