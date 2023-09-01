using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra;

public interface IOrchestrationActivityCallSupplier
{
    ValueTask<Result<OrchestrationActivityCallOut<TOut>, Failure<HandlerFailureCode>>> CallActivityAsync<TIn, TOut>(
        OrchestrationActivityCallIn<TIn> input, CancellationToken cancellationToken);

    ValueTask<Result<Unit, Failure<HandlerFailureCode>>> CallActivityAsync<TIn>(
        OrchestrationActivityCallIn<TIn> input, CancellationToken cancellationToken);
}