
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record NormalFoodGetByIdQuery(int Id) : IRequest<NormalFoodQueryModel>;
}
