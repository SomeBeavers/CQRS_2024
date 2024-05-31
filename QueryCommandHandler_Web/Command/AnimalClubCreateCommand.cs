
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AnimalClubCreateCommand(AnimalClubCommandModel AnimalClubCommandModel) : IRequest<int>;
}
