
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record MapToQueryUpdateCommand(MapToQueryCommandModel MapToQueryCommandModel) : IRequest<int>;
}
