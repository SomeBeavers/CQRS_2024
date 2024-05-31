
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class LocationGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<LocationGetByIdQuery, LocationQueryModel>
    {
        public async Task<LocationQueryModel> Handle(LocationGetByIdQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
        