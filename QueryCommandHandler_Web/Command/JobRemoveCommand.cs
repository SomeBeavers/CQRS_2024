
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record JobRemoveCommand(JobCommandModel JobCommandModel) : IRequest<int>;
}
