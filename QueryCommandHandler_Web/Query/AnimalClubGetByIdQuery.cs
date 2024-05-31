
using MediatR;
using QueryCommandHandler_Web.QueryModels;

namespace QueryCommandHandler_Web.Query
{
    public record AnimalClubGetByIdQuery(int Id) : IRequest<AnimalClubQueryModel>;
}
