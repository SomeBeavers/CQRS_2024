
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AdditionalInfoUpdateCommand(AdditionalInfoCommandModel AdditionalInfoCommandModel) : IRequest<int>;
}
