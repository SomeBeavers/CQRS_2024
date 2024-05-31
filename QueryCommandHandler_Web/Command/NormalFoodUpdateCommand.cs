
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record NormalFoodUpdateCommand(NormalFoodCommandModel NormalFoodCommandModel) : IRequest<int>;
}
