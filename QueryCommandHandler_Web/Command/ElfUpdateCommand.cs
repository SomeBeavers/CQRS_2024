
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ElfUpdateCommand(ElfCommandModel ElfCommandModel) : IRequest<int>;
}
