
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class NormalFoodGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<NormalFoodGetByIdQuery, NormalFoodQueryModel>
    {
        public async Task<NormalFoodQueryModel> Handle(NormalFoodGetByIdQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
        