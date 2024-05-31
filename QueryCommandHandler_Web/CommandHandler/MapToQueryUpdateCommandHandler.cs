
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class MapToQueryUpdateCommandHandler(AnimalContext context) : IRequestHandler<MapToQueryUpdateCommand, int>
    {
        public async Task<int> Handle(MapToQueryUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
