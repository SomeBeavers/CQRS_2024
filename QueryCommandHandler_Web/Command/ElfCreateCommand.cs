
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ElfCreateCommand(ElfCommandModel ElfCommandModel) : IRequest<int>;
}
