
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record BeaverCreateCommand(BeaverCommandModel BeaverCommandModel) : IRequest<int>;
}
