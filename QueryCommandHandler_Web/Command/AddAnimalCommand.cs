using MediatR;
using QueryCommand_App.CommandModels;
using QueryCommandHandler_Web.QueryModels;

namespace ConsoleApp_Core
{
    // Include properties to be used as input for the command
    public record AddAnimalCommand(AnimalCommandModel animalCommandModel) : IRequest<int>;
}