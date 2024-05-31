
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AdditionalInfoDetailedUpdateCommand(AdditionalInfoDetailedCommandModel AdditionalInfoDetailedCommandModel) : IRequest<int>;
}
