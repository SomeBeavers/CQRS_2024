
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record DeerUpdateCommand(DeerCommandModel DeerCommandModel) : IRequest<int>;
}
