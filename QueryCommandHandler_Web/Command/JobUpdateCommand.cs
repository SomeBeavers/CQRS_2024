
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record JobUpdateCommand(JobCommandModel JobCommandModel) : IRequest<int>;
}
