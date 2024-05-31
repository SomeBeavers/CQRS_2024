
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record MapToQueryGetByIdQuery(int Id) : IRequest<MapToQueryQueryModel>;
}
