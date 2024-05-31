
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class MapToQueryGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<MapToQueryGetByIdQuery, MapToQueryQueryModel>
    {
        public async Task<MapToQueryQueryModel> Handle(MapToQueryGetByIdQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
        