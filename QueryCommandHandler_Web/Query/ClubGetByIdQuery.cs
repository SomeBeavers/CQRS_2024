
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record ClubGetByIdQuery(int Id) : IRequest<ClubQueryModel>;
}
