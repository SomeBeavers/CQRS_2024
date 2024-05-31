
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class CrowGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<CrowGetByIdQuery, CrowQueryModel>
    {
        public async Task<CrowQueryModel> Handle(CrowGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Crows.FindAsync(request.Id, cancellationToken))!.ToCrowQueryModel();
        }
    }
}
        