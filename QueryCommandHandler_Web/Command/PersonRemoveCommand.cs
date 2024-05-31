
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record PersonRemoveCommand(PersonCommandModel PersonCommandModel) : IRequest<int>;
}
