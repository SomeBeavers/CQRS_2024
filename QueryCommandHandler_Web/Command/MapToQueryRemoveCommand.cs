
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record MapToQueryRemoveCommand(MapToQueryCommandModel MapToQueryCommandModel) : IRequest<int>;
}
