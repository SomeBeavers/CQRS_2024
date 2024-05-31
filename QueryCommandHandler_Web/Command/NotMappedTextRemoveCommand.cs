
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record NotMappedTextRemoveCommand(NotMappedTextCommandModel NotMappedTextCommandModel) : IRequest<int>;
}
