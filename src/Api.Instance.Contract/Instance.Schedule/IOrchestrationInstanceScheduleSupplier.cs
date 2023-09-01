using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Infra;

public interface IOrchestrationInstanceScheduleSupplier
{
    ValueTask<Result<OrchestrationInstanceScheduleOut, Failure<HandlerFailureCode>>> ScheduleInstanceAsync<TIn>(
        OrchestrationInstanceScheduleIn<TIn> input, CancellationToken cancellationToken);
}