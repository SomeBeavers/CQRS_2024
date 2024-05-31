
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record LocationRemoveCommand(LocationCommandModel LocationCommandModel) : IRequest<int>;
}
