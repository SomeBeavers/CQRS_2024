
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class DeerGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<DeerGetByIdQuery, DeerQueryModel>
    {
        public async Task<DeerQueryModel> Handle(DeerGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Deers.FindAsync(request.Id, cancellationToken))!.ToDeerQueryModel();
        }
    }
}
        