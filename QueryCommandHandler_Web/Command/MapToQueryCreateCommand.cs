
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record MapToQueryCreateCommand(MapToQueryCommandModel MapToQueryCommandModel) : IRequest<int>;
}
