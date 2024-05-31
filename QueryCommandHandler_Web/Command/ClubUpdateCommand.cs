
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ClubUpdateCommand(ClubCommandModel ClubCommandModel) : IRequest<int>;
}
