
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record BeaverUpdateCommand(BeaverCommandModel BeaverCommandModel) : IRequest<int>;
}
