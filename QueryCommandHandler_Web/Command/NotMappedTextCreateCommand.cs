
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record NotMappedTextCreateCommand(NotMappedTextCommandModel NotMappedTextCommandModel) : IRequest<int>;
}
