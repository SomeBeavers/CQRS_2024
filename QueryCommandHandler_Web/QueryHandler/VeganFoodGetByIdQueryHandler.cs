
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class VeganFoodGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<VeganFoodGetByIdQuery, VeganFoodQueryModel>
    {
        public async Task<VeganFoodQueryModel> Handle(VeganFoodGetByIdQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
        