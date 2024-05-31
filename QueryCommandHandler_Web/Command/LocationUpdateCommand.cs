
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record LocationUpdateCommand(LocationCommandModel LocationCommandModel) : IRequest<int>;
}
