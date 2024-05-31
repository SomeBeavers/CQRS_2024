
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record AnimalLocationGetByIdQuery(int Id) : IRequest<AnimalLocationQueryModel>;
}
