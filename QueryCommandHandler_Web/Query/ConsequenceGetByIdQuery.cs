
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record ConsequenceGetByIdQuery(int Id) : IRequest<ConsequenceQueryModel>;
}
