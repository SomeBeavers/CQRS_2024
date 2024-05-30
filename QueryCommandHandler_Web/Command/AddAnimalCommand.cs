using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    // Include properties to be used as input for the command
    public record AddAnimalCommand(AnimalCommandModel AnimalCommandModel) : IRequest<int>;
}