
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record CrowCreateCommand(CrowCommandModel CrowCommandModel) : IRequest<int>;
}
