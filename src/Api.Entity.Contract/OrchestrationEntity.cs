namespace GarageGroup.Infra;

public sealed record class OrchestrationEntity
{
    public OrchestrationEntity(string name, string key)
    {
        Name = name ?? string.Empty;
        Key = key ?? string.Empty;
    }

    public string Name { get; }

    public string Key { get; }
}