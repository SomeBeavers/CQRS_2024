
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AnimalClubUpdateCommand(AnimalClubCommandModel AnimalClubCommandModel) : IRequest<int>;
}
