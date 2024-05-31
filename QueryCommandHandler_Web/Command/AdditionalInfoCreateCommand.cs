
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AdditionalInfoCreateCommand(AdditionalInfoCommandModel AdditionalInfoCommandModel) : IRequest<int>;
}
