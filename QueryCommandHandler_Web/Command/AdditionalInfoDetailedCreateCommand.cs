
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AdditionalInfoDetailedCreateCommand(AdditionalInfoDetailedCommandModel AdditionalInfoDetailedCommandModel) : IRequest<int>;
}
