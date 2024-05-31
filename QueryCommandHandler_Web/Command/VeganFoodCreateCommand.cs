
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record VeganFoodCreateCommand(VeganFoodCommandModel VeganFoodCommandModel) : IRequest<int>;
}
