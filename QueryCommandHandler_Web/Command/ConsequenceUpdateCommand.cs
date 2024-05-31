
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ConsequenceUpdateCommand(ConsequenceCommandModel ConsequenceCommandModel) : IRequest<int>;
}
