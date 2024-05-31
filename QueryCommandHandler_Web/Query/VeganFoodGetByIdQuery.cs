
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record VeganFoodGetByIdQuery(int Id) : IRequest<VeganFoodQueryModel>;
}
