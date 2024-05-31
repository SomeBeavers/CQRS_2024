
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record DrawbackUpdateCommand(DrawbackCommandModel DrawbackCommandModel) : IRequest<int>;
}
