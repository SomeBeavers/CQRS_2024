
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record JobDrawbackRemoveCommand(JobDrawbackCommandModel JobDrawbackCommandModel) : IRequest<int>;
}
