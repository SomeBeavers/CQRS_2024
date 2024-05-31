
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class JobDrawbackGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<JobDrawbackGetByIdQuery, JobDrawbackQueryModel>
    {
        public async Task<JobDrawbackQueryModel> Handle(JobDrawbackGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.JobDrawbacks.FindAsync(request.Id, cancellationToken))!.ToJobDrawbackQueryModel();
        }
    }
}
        