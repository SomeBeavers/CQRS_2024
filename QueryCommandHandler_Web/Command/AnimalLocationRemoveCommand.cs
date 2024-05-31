
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AnimalLocationRemoveCommand(AnimalLocationCommandModel AnimalLocationCommandModel) : IRequest<int>;
}
