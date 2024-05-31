
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AdditionalInfoRemoveCommand(AdditionalInfoCommandModel AdditionalInfoCommandModel) : IRequest<int>;
}
