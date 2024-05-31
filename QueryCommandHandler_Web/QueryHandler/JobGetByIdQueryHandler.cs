
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class JobGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<JobGetByIdQuery, JobQueryModel>
    {
        public async Task<JobQueryModel> Handle(JobGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Jobs.FindAsync(request.Id, cancellationToken))!.ToJobQueryModel();
        }
    }
}
        