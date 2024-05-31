
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class LocationUpdateCommandHandler(AnimalContext context) : IRequestHandler<LocationUpdateCommand, int>
    {
        public async Task<int> Handle(LocationUpdateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
