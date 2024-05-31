
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ClubRemoveCommand(ClubCommandModel ClubCommandModel) : IRequest<int>;
}
