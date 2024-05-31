
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record DrawbackRemoveCommand(DrawbackCommandModel DrawbackCommandModel) : IRequest<int>;
}
