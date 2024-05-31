
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AnimalRemoveCommand(AnimalCommandModel AnimalCommandModel) : IRequest<int>;
}
