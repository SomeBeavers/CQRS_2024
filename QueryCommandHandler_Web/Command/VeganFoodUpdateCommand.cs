
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record VeganFoodUpdateCommand(VeganFoodCommandModel VeganFoodCommandModel) : IRequest<int>;
}
