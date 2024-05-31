
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record JobDrawbackCreateCommand(JobDrawbackCommandModel JobDrawbackCommandModel) : IRequest<int>;
}
