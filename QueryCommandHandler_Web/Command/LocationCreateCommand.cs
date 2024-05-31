
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record LocationCreateCommand(LocationCommandModel LocationCommandModel) : IRequest<int>;
}
