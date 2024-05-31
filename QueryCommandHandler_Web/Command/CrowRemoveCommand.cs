
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record CrowRemoveCommand(CrowCommandModel CrowCommandModel) : IRequest<int>;
}
