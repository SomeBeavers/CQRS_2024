
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record PersonUpdateCommand(PersonCommandModel PersonCommandModel) : IRequest<int>;
}
