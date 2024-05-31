
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    public record AnimalLocationUpdateCommand(AnimalLocationCommandModel AnimalLocationCommandModel) : IRequest<int>;
}
