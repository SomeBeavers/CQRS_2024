
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record LocationGetByIdQuery(int Id) : IRequest<LocationQueryModel>;
}
