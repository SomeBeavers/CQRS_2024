
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record BeaverRemoveCommand(BeaverCommandModel BeaverCommandModel) : IRequest<int>;
}
