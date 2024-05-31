
using DatabaseLib;
using MediatR;
using QueryCommandHandler_Web.CommandModels;

namespace QueryCommandHandler_Web.Command
{
    internal sealed class VeganFoodCreateCommandHandler(AnimalContext context) : IRequestHandler<VeganFoodCreateCommand, int>
    {
        public async Task<int> Handle(VeganFoodCreateCommand request, CancellationToken cancellationToken)
        {
            // context.Animals.Add(request.AnimalCommandModel.ToAnimal());
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
