
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.Query;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.QueryHandler
{
    internal sealed class FoodGetByIdQueryHandler(AnimalContext context)
        : IRequestHandler<FoodGetByIdQuery, FoodQueryModel>
    {
        public async Task<FoodQueryModel> Handle(FoodGetByIdQuery request, CancellationToken cancellationToken)
        {
            return (await context.Food.FindAsync(request.Id, cancellationToken))!.ToFoodQueryModel();
        }
    }
}
        