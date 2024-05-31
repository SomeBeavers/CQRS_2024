
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record BeaverGetByIdQuery(int Id) : IRequest<BeaverQueryModel>;
}
