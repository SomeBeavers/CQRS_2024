
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record VeganFoodRemoveCommand(VeganFoodCommandModel VeganFoodCommandModel) : IRequest<int>;
}
