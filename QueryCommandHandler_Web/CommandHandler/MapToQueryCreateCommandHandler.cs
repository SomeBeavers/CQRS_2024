
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class MapToQueryCreateCommandHandler(AnimalContext context) : IRequestHandler<MapToQueryCreateCommand, int>
    {
        public async Task<int> Handle(MapToQueryCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
