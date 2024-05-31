
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ConsequenceCreateCommand(ConsequenceCommandModel ConsequenceCommandModel) : IRequest<int>;
}
