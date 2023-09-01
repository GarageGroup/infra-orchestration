using System;

namespace GarageGroup.Infra;

public interface IOrchestrationInstanceId : IEquatable<IOrchestrationInstanceId>
{
    public string Id { get; }
}