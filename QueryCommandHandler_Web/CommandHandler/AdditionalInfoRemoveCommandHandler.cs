
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class AdditionalInfoRemoveCommandHandler(AnimalContext context) : IRequestHandler<AdditionalInfoRemoveCommand, int>
    {
        public async Task<int> Handle(AdditionalInfoRemoveCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
