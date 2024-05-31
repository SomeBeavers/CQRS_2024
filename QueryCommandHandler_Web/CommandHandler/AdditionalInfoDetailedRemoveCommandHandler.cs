
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AdditionalInfoDetailedRemoveCommandHandler(AnimalContext context) : IRequestHandler<AdditionalInfoDetailedRemoveCommand, int>
    {
        public async Task<int> Handle(AdditionalInfoDetailedRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
