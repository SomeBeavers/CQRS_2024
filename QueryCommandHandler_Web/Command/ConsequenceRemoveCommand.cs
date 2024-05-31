
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ConsequenceRemoveCommand(ConsequenceCommandModel ConsequenceCommandModel) : IRequest<int>;
}
