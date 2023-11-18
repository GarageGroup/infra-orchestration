using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra;

public interface IOrchestrationEntitySignalSupplier
{
    ValueTask<Result<Unit, Failure<HandlerFailureCode>>> SignalEntityAsync<TIn>(
        OrchestrationEntitySignalIn<TIn> input, CancellationToken cancellationToken);
}