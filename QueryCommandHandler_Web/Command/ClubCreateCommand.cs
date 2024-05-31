
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record ClubCreateCommand(ClubCommandModel ClubCommandModel) : IRequest<int>;
}
