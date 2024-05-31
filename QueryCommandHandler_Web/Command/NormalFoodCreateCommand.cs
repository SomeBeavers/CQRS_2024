
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record NormalFoodCreateCommand(NormalFoodCommandModel NormalFoodCommandModel) : IRequest<int>;
}
