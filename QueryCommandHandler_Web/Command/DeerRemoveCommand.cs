
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record DeerRemoveCommand(DeerCommandModel DeerCommandModel) : IRequest<int>;
}
