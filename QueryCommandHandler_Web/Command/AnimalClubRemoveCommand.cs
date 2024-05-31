
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AnimalClubRemoveCommand(AnimalClubCommandModel AnimalClubCommandModel) : IRequest<int>;
}
