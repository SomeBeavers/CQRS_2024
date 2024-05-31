
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record PersonGetByIdQuery(int Id) : IRequest<PersonQueryModel>;
}
