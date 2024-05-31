
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class AdditionalInfoGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<AdditionalInfoGetByIdQuery, AdditionalInfoQueryModel>
    {
        public async Task<AdditionalInfoQueryModel> Handle(AdditionalInfoGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.AdditionalInfos.FindAsync(request.Id, cancellationToken))!.ToAdditionalInfoQueryModel();
        }
    }
}
        