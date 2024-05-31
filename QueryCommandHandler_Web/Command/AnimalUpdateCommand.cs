
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AnimalUpdateCommand(AnimalCommandModel AnimalCommandModel) : IRequest<int>;
}
