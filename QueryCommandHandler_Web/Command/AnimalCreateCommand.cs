
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AnimalCreateCommand(AnimalCommandModel AnimalCommandModel) : IRequest<int>;
}
