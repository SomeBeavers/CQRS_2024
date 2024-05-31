
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AdditionalInfoDetailedCreateCommandHandler(AnimalContext context) : IRequestHandler<AdditionalInfoDetailedCreateCommand, int>
    {
        public async Task<int> Handle(AdditionalInfoDetailedCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
