
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record GradeCreateCommand(GradeCommandModel GradeCommandModel) : IRequest<int>;
}
