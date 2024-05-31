
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record CrowUpdateCommand(CrowCommandModel CrowCommandModel) : IRequest<int>;
}
