
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record GradeRemoveCommand(GradeCommandModel GradeCommandModel) : IRequest<int>;
}
