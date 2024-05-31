
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class MapToQueryRemoveCommandHandler(AnimalContext context) : IRequestHandler<MapToQueryRemoveCommand, int>
    {
        public async Task<int> Handle(MapToQueryRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
