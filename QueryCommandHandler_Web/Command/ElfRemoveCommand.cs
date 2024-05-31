
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ElfRemoveCommand(ElfCommandModel ElfCommandModel) : IRequest<int>;
}
