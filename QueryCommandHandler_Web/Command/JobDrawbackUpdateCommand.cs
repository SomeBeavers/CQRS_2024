
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record JobDrawbackUpdateCommand(JobDrawbackCommandModel JobDrawbackCommandModel) : IRequest<int>;
}
