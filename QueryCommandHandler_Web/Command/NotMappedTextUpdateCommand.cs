
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record NotMappedTextUpdateCommand(NotMappedTextCommandModel NotMappedTextCommandModel) : IRequest<int>;
}
